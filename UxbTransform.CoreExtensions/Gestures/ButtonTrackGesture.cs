using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using UxbTransform.DeviceComponents;

namespace UxbTransform.Gestures
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Gesture("ButtonTrackGesture")]
    public class ButtonTrackGesture : Gesture, IQuantifiedGesture
    {
        ButtonState _oldState;
        String[] _providedValues = new String[] { "ButtonState" };

        [UserProperty]
        public ButtonDeviceComponent Button { get; set; }

        public ButtonTrackGesture()
        {
            _oldState = ButtonState.Up;
        }

        public override Boolean IsGestureActivated()
        {
            if (Button.State == _oldState)
                return false;

            _oldState = Button.State;
            return true;
        }

        public Boolean HasValue(String key)
        {
            return _providedValues.Contains(key);
        }

        public Object GetValue(String key)
        {
            if (key == "ButtonState")
                return Button.State == ButtonState.Up ? false : true;

            throw new ApplicationException();
        }

        public override String ToString()
        {
            if (Button == null)
                return "presses or releases unassigned button";

            return String.Format("presses or releases '{0}' on {1}", Button.Name, Button.Owner);
        }   
    }
}
