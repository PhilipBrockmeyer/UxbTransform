using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public class GestureEventArgs : EventArgs
    {
        public Gesture Gesture { get; private set; }

        public GestureEventArgs(Gesture gesture)
        {
            Gesture = gesture;
        }
    }
}
