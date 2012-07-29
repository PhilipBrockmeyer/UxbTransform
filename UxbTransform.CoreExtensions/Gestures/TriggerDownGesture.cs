using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using UxbTransform.CoreExtensions.DeviceComponents;

namespace UxbTransform.CoreExtensions.Gestures
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Gesture("TriggerDownGesture")]
    public class TriggerDownGesture : Gesture
    {
        [UserProperty]
        public TriggerDeviceComponent Trigger { get; set; }

        Boolean _isPressed;

        public TriggerDownGesture()
        {
            _isPressed = false;
        }

        public override Boolean IsGestureActivated()
        {
            if (Trigger == null)
                return false;

            if (Trigger.Position < 0.95f)
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
            if (Trigger == null)
                return "presses unassigned trigger";

            return String.Format("presses '{0}' on {1}", Trigger.Name, Trigger.Owner);
        }   
    }
}
