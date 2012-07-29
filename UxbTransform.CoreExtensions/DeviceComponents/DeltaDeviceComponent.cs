using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform.DeviceComponents
{
    public class DeltaDeviceComponent : DeviceComponent
    {
        public Int32 Delta { get; set; }

        public DeltaDeviceComponent(Device owner)
            : base(owner)
        {
                
        }
    }
}
