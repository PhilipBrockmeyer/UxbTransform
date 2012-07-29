using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UxbTransform.DeviceComponents;
using System.ComponentModel.Composition;

namespace UxbTransform.Modifiers
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Modifier("DelayedButtonDownModifier")]
    public class DelayedButtonDownModifier : Modifier
    {
        Boolean _isPressed;
        Int32 _pressTime = 0;

        [UserProperty]
        public Int32 Delay { get; set; }

        [UserProperty]
        public ButtonDeviceComponent Button { get; set; }

        public DelayedButtonDownModifier()
        {
            Delay = 500;
        }

        protected override bool IsActive()
        {
            if (Button.State == ButtonState.Up)
            {
                _isPressed = false;
                return false;
            }

            if (!_isPressed)
            {
                _pressTime = Environment.TickCount;
                _isPressed = true;
            }

            if ((Environment.TickCount - _pressTime) < Delay)
                return false;

            return true;
        }
    }
}
