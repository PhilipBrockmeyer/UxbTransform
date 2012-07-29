using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel.Composition;
using UxbTransform.DeviceComponents;

namespace UxbTransform.Gestures
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Gesture("PositionChangeGesture")]
    public class PositionChangeGesture : Gesture, IQuantifiedGesture
    {
        [UserProperty]
        public PositionalDeviceComponent Cursor { get; set; }

        public PositionChangeGesture()
        {

        }

        public override Boolean IsGestureActivated()
        {
            return true;
        }

        public Object GetValue(String key)
        {
            if (key == "XPosition")
                return Cursor.X;

            if (key == "YPosition")
                return Cursor.Y;

            throw new ApplicationException("Unexpected key.");
        }

        public Boolean HasValue(String key)
        {
            if (Cursor == null)
                return false;

            if (key == "XPosition" || key == "YPosition")
                return true;

            return false;
        }

        public override String ToString()
        {
            if (Cursor == null)
                return "moves unassigned cursor";

            return String.Format("moves the '{0}' of {1}", Cursor.Name, Cursor.Owner);
        }   
    }
}
