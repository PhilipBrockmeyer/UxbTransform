using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UxbTransform
{
    public class DeviceManager
    {
        IEnumerable<Device> _devices;
        INotifier _notifier;
        
        public event EventHandler DeviceStateChanged;

        public DeviceManager(IEnumerable<Device> devices, INotifier notifier)
        {
            _devices = devices;
            _notifier = notifier;
        }

        public void ConnectDevices()
        {
            foreach (var device in _devices)
            {
                if (device == null)
                {
                    _notifier.Notify("Device Error", String.Format("There was an error loading a device, see log for details."));
                    continue;
                }
                try
                {
                    if (!device.Connect())
                    {
                        _notifier.Notify(
                            String.Empty,
                            String.Format("Failed to connect to device '{0}'", device.Name));
                    }
                    else
                    {
                        device.DeviceStateChanged += new EventHandler(device_DeviceStateChanged);
                    }
                }
                catch (Exception ex)
                {
                    _notifier.Notify(
                        String.Empty,
                        String.Format
                        (
                            "Failed to connect to device '{0}' {1} {2}",                        
                            device.Name,
                            Environment.NewLine,
                            ex.Message
                        )
                    );
                }
            }
        }

        public void ReconnectDevices()
        {
            DisconnectDevices();
            ConnectDevices();
        }

        public void DisconnectDevices()
        {
            foreach (var device in _devices)
            {
                try
                {
                    device.DeviceStateChanged -= device_DeviceStateChanged; 
                    device.Disconnect();
                }
                catch (Exception) { }
            }
        }


        void device_DeviceStateChanged(object sender, EventArgs e)
        {
            OnDeviceStateChanged();
        }

        protected void OnDeviceStateChanged()
        {
            if (DeviceStateChanged != null)
                DeviceStateChanged(this, EventArgs.Empty);
        }
    }
}
