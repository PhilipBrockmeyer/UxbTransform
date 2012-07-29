using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using UxbTransform.Configuration;

namespace UxbTransform.Configuration
{
    public class DeviceBinding
    {
        String _bindingString;
        String[] _parms;

        public DeviceComponent DeviceComponent { get; private set; }

        public DeviceBinding(String bindingString)
        {
            if (bindingString == null)
            {
                Log.Add("An empty device binding string was encountered.");
                return;
            }

            _bindingString = bindingString;

            var match = Regex.Match(bindingString, @"{DeviceBinding (?<Parms>.*)}");

            _parms = match.Groups["Parms"].Value.Split(',');

            Device device;

            String deviceName = GetParameterValue("Name");
            if (String.IsNullOrEmpty(deviceName))
                throw new ApplicationException("Name parameter is required on device binding.");

            device = Configuration.Current.Devices.Where(p => p.Name == deviceName).Single().GetDevice();

            if (device == null)
            {
                DeviceComponent = null;
                Log.Add(String.Format("No device named {0} was registered.", deviceName));
                return;
            }

            String path = GetParameterValue("Path");
            
            DeviceComponent = (DeviceComponent)device.GetType().GetProperty(path).GetValue(device, null);
        }

        private String GetParameterValue(String parameterName)
        {
            var parm = (from p in _parms
                        where Regex.IsMatch(p.Trim(), @"^" + parameterName + @"[\s]*=.*")
                        select p).FirstOrDefault();

            if (String.IsNullOrEmpty(parm))
                return null;

            return parm.Trim().Split('=')[1];
        }
    }
}
