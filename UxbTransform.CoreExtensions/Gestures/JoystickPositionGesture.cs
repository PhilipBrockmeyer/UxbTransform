using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using UxbTransform.DeviceComponents;

namespace UxbTransform.CoreExtensions.Gestures
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Gesture("JoystickPositionGesture")]
    public class JoystickPositionGesture : Gesture, IQuantifiedGesture
    {
        [UserProperty]
        public JoystickDeviceComponent Joystick { get; set; }

        public override bool IsGestureActivated()
        {
            if (Joystick == null)
                return false;

            return true;
        }

        public Boolean HasValue(String key)
        {
            if (key == "XAxis" || key == "YAxis")
                return true;

            return false;
        }

        public Object GetValue(String key)
        {
            if (key == "XAxis")
                return Joystick.XAxis;

            if (key == "YAxis")
                return Joystick.YAxis;

            throw new ApplicationException();
        }

        public override String ToString()
        {
            return String.Format("moves the {0}", Joystick.Name);
        }
    }
}
