using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace UxbTransform.DeviceComponents
{
    /// <summary>
    /// A device component that measures a position on a 2 dimensional plane.
    /// </summary>
    /// <remarks>
    /// Values range from (0.0, 0.0) to (1.0, 1.0) representing top-left and bottom-right respectively.
    /// </remarks>
    public class PositionalDeviceComponent : DeviceComponent
    {
        public Single X { get; set; }
        public Single Y { get; set; }

        public PositionalDeviceComponent(Device owner)
            : base(owner)
        {

        }

        public override string ToString()
        {
            return String.Format("{0} X:{1} Y{2}", Name, X, Y);
        }
    }
}
