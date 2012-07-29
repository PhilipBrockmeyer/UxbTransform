using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using UxbTransform.DeviceComponents;

namespace UxbTransform.Modifiers
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Modifier("ButtonDownModifier")]
    public class ButtonDownModifier : Modifier
    {
        [UserProperty]
        public ButtonDeviceComponent Button { get; set; }

        protected override Boolean IsActive()
        {
            if (Button == null)
                return false;

            return Button.State == ButtonState.Down;
        }
    }
}
