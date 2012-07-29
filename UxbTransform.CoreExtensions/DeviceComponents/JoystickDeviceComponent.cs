using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform.DeviceComponents
{

    public class JoystickDeviceComponent : DeviceComponent
    {
        public Single XAxis { get; set; }
        public Single YAxis { get; set; }

        public JoystickDeviceComponent(Device owner)
            : base (owner)
        {

        }
    }
}
