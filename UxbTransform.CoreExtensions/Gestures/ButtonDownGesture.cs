using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UxbTransform.DeviceComponents;
using System.ComponentModel.Composition;

namespace UxbTransform.Gestures
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Gesture("ButtonDownGesture")]
    public class ButtonDownGesture : Gesture
    {
        [UserProperty]
        public ButtonDeviceComponent Button { get; set; }

        Boolean _isPressed;


        public ButtonDownGesture()
        {
            _isPressed = false;
        }

        public override Boolean IsGestureActivated()
        {
            if (Button == null)
                return false;

            if (Button.State != ButtonState.Down)
            {
                _isPressed = false;
                return false;
            }

            if (_isPressed)
                return false;

            _isPressed = true;
            return true;
        }

        public override String ToString()
        {
            if (Button == null)
                return "presses unassigned button";

            return String.Format("presses '{0}' on {1}", Button.Name, Button.Owner);
        }   
    }
}
