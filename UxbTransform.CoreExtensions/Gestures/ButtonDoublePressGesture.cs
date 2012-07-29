using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using UxbTransform.DeviceComponents;
using System.ComponentModel.Composition;

namespace UxbTransform.Gestures
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Gesture("ButtonDoublePressGesture")]
    public class ButtonDoublePressGesture : Gesture
    {
        /// <summary>
        /// The time in milliseconds in which the presses must be completed.
        /// </summary>
        public Int32 PressSpeed { get; set; }

        [UserProperty]
        public ButtonDeviceComponent Button{ get; set; }

        ButtonState _previousState = ButtonState.Up;
        Int32 _previousPressTime = 0;

        public ButtonDoublePressGesture()
        {
            PressSpeed = 300;
        }

        public override Boolean IsGestureActivated()
        {
            if (Button == null)
                return false;

            if (Button.State == _previousState)
                return false;

            _previousState = Button.State;

            if (Button.State != ButtonState.Up)
                return false;

            Int32 ellapsedTime = Environment.TickCount - _previousPressTime;
            _previousPressTime = Environment.TickCount;

            if (ellapsedTime > PressSpeed)
                return false;

            return true;
        }

        public override String ToString()
        {
            if (Button == null)
                return "double clicks unassigned button";

            return String.Format("double clicks '{0}' on {1}", Button.Name, Button.Owner);
        }   
    }
}
