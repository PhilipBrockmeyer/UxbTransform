using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform.DeviceComponents
{
    /// <summary>
    /// A device component that tracks the orientation of the device.  Values range from -1.0 to 1.0.
    /// </summary>
    public class AccelerometerDeviceComponent : DeviceComponent
    {
        public Single XAxis { get; set; }
        public Single YAxis { get; set; }
        public Single ZAxis { get; set; }
        
        public AccelerometerDeviceComponent(Device owner) 
            : base(owner)
        {

        }
    }
}
