using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UxbTransform.DeviceComponents;
using System.ComponentModel.Composition;

namespace UxbTransform.Gestures
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Gesture("ButtonPressGesture")]
    public class ButtonPressGesture : Gesture
    {
        [UserProperty]
        public ButtonDeviceComponent Button { get; set; }

        ButtonState _previousState;

        public ButtonPressGesture()
        {
            _previousState = ButtonState.Up;
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

            return true;
        }

        public override String ToString()
        {
            if (Button == null)
                return "releases unassigned button";

            return String.Format("releases '{0}' on {1}", Button.Name, Button.Owner);
        }   
    }
}
