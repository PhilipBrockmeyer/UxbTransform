using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public abstract class Device : IDisposable
    {
        IList<String> _deviceErrors;
        IDictionary<String, DeviceComponent> _components;

        public event EventHandler DeviceStateChanged;

        protected abstract Boolean ConnectImplementation();
        protected abstract void DisconnectImplementation();

        public String Name { get; set; }
        public Int32 Index { get; set; }
        public Boolean IsConnected { get; private set; }

        public IEnumerable<String> Errors { get { return _deviceErrors; } }

        public Device()
        {
            _components = new Dictionary<String, DeviceComponent>();
            _deviceErrors = new List<String>();
            IsConnected = false;
        }

        public Boolean Connect()
        {
            var result = ConnectImplementation();
            IsConnected = result;
            return result;
        }

        public void Disconnect()
        {
            IsConnected = false;
            DisconnectImplementation();
        
        }

        public void Dispose()
        {
            Disconnect();
        }

        public IEnumerable<DeviceComponent> QueryDeviceComponents()
        {
            return DeviceComponentHelper.QueryDeviceComponents(this);
        }

        protected void AddDeviceError(String error)
        {
            _deviceErrors.Add(error);
        }

        protected virtual void OnDeviceStateChanged()
        {
            if (DeviceStateChanged != null)
                DeviceStateChanged(this, EventArgs.Empty);
        }
    }
}
