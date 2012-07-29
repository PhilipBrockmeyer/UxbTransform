using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform.CoreExtensions.DeviceComponents
{
    public class TriggerDeviceComponent : DeviceComponent
    {
        public Single Position { get; set; }

        public TriggerDeviceComponent(Device owner)
            : base(owner)
        {

        }
    }
}
