using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public struct DeviceInfo
    {
        Lazy<Device, IDictionary<String, Object>> _value;

        public DeviceInfo (Lazy<Device, IDictionary<String, Object>> value)
	    {
            _value = value;
	    }

        public Device Device { get { return _value.Value; } }
        public String Name { get { return (String)_value.Metadata["Name"]; } }
        public String Key { get { return (String)_value.Metadata["Key"]; } }

        public override String ToString()
        {
            return Name;
        }
    }
}
