using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using UxbTransform.DeviceComponents;

namespace UxbTransform.Gestures
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Gesture("DeltaGesture")]
    public class DeltaGesture : Gesture, IQuantifiedGesture
    {
        [UserProperty]
        public DeltaDeviceComponent Component { get; set; }

        public override Boolean IsGestureActivated()
        {
            if (Component.Delta == 0)
                return false;

            return true;
        }

        public Boolean HasValue(String key)
        {
            if (key == "DeltaValue")
                return true;

            return false;
        }

        public Object GetValue(String key)
        {
            if (key == "DeltaValue")
                return Component.Delta;

            throw new ApplicationException();
        }

        public override String ToString()
        {
            return String.Format("alters {0}", Component.Name);
        }
    }
}
