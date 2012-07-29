using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UxbTransform.DeviceComponents;
using System.ComponentModel.Composition;

namespace UxbTransform.Gestures
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Gesture("ButtonPressAndHoldGesture")]
    public class ButtonPressAndHoldGesture : Gesture
    {
        [UserProperty]
        public ButtonDeviceComponent Button { get; set; }

        [UserProperty]
        public Int32 HoldDuration { get; set; }

        Int32 _pressTime = -10000;
        Boolean _isPressed;
        Boolean _hasGestureBeenRaised;

        public ButtonPressAndHoldGesture()
        {
            _isPressed = false;
            HoldDuration = 1000;
        }

        public override Boolean IsGestureActivated()
        {
            if (Button == null)
                return false;

            if (Button.State == ButtonState.Up)
            {
                _isPressed = false;
                _hasGestureBeenRaised = false;
                return false;
            }

            if (_hasGestureBeenRaised)
                return false;

            if (!_isPressed)
            {
                _isPressed = true;
                _pressTime = Environment.TickCount;
                return false;
            }

            if ((Environment.TickCount - _pressTime) < HoldDuration)
                return false;

            _hasGestureBeenRaised = true;
            return true;
        }

        public override String ToString()
        {
            if (Button == null)
                return "presses and holds unassigned button";

            return String.Format("presses and holds '{0}' on {1}", Button.Name, Button.Owner);
        }   
    }
}
