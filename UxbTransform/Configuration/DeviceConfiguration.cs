using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace UxbTransform.Configuration
{
    public class DeviceConfiguration
    {
        [XmlAttribute("type")]
        public String Type { get; set; }

        [XmlAttribute("name")]
        public String Name { get; set; }


        [XmlAttribute("index")]
        public Int32 Index { get; set; }

        Device _device;

        public Device GetDevice()
        {
            return _device;
        }

        public Device BuildDevice()
        {
            if (Type == null)
            {
                Log.Add(String.Format("No device type was specified for {0}.", Name));
                return null;
            }

            try
            {
                _device = ServiceLocator.GetDevice(Type);
            }
            catch (InvalidOperationException)
            {
                Log.Add(String.Format("The device type {0} was not found in plug in library.", Type));
                return null;
            }

            _device.Name = Name;
            _device.Index = Index;

            return _device;
        }

        public override String ToString()
        {
            return Name;
        }
    }
}
