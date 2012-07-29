using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform.DeviceComponents
{
    public class ButtonDeviceComponent : DeviceComponent
    {
        public ButtonDeviceComponent(Device owner)
            : base (owner)
        {

        }

        public ButtonState State { get; set; }
    }
}
