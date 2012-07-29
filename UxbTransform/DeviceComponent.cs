using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public abstract class DeviceComponent
    {
        public Device Owner { get; private set; }
        public String Name { get; set; }

        public DeviceComponent(Device owner)
        {
            Owner = owner;
        }

        public override String ToString()
        {
            return Name;
        }
    }
}
