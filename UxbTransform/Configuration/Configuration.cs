using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel.Composition.Hosting;

namespace UxbTransform.Configuration
{
    [XmlRoot("Configuration")]
    public class Configuration
    {
        static Configuration _current;

        public static Configuration Current { get { return _current; } }

        ApplicationSet _appSet;
        
        public Configuration()
        {
        }

        [XmlArray("Applications")]
        [XmlArrayItem("Application")]
        public List<ApplicationConfiguration> Applications { get; set; }

        [XmlArray("Devices")]
        [XmlArrayItem("Device")]
        public List<DeviceConfiguration> Devices { get; set; }

        public TransformationModel Configure()
        {
            Log.Clear();
            Log.Add("Applying configuration...");
            _current = this;

            var devices = LoadDevices();
            LoadApplications();

            Log.Add("Done applying configuration.");
            return new TransformationModel() { Applications = _appSet, Devices = devices };
        }

        private void LoadApplications()
        {
            Log.Add("Loading applications...");
            _appSet = new ApplicationSet();

            foreach (var app in Applications)
            {
                _appSet.AddApplication(app.ProcessName, app.BuildInputMap());
            }
        }

        private IEnumerable<Device> LoadDevices()
        {
            Log.Add("Loading devices...");
            List<Device> devices = new List<Device>();

            foreach (var device in Devices)
            {
                devices.Add(device.BuildDevice());
            }

            return devices;
        }

        public void RemoveDevice(DeviceConfiguration device)
        {
            Devices.Remove(device);
        }

        public void AddDevice(DeviceConfiguration device)
        {
            Devices.Add(device);
        }

        public void AddApplication(ApplicationConfiguration application)
        {
            Applications.Add(application);
        }

        public void RemoveApplication(ApplicationConfiguration application)
        {
            Applications.Remove(application);
        }
    }
}
