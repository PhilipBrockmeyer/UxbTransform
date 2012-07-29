using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UxbTransform.DeviceComponents;
using UxbTransform.Configuration;
using System.Text.RegularExpressions;
using System.ComponentModel.Composition;

namespace UxbTransform.UI.PropertySetters
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [PropertySetterUI(typeof(ButtonDeviceComponent))]
    public partial class ButtonDeviceComponentSetter : UserControl, IPropertySetterUI
    {
        PropertySetterConfiguration _model;
        Device _device;

        public ButtonDeviceComponentSetter()
        {
            InitializeComponent();
        }

        public String Property { get; private set; }

        public void Initialize(PropertySetterConfiguration model)
        {
            _model = model;
            Property = _model.Property;

            cboDevices.Items.Clear();

            foreach (var device in Configuration.Configuration.Current.Devices)
                cboDevices.Items.Add(device);
        }

        public PropertySetterConfiguration GetValue()
        {
            _model.Value = null;

            if (_device == null)
                return _model;

            if (cboButton.SelectedItem == null)
                return _model;

            String button = DeviceComponentHelper.GetPropertyName(_device, ((ButtonDeviceComponent)cboButton.SelectedItem).Name);
            _model.Value = "{DeviceBinding Path=" + button + ", Name=" + ((DeviceConfiguration)cboDevices.SelectedItem).Name + "}";
            return _model;
        }

        private void SelectDevice()
        {
            _device = ServiceLocator.GetDevice(
                        ((DeviceConfiguration)cboDevices.SelectedItem).Type
                      );

            var buttons = DeviceComponentHelper.QueryDeviceComponents(_device, typeof(ButtonDeviceComponent));

            cboButton.Items.Clear();

            foreach (var button in buttons)
                cboButton.Items.Add(button);
        }

        private void cboDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectDevice();
        }

        public void SetValue(String value)
        {
            if (value == null)
                return;

            String name = Regex.Match(value, @"Name=(?<name>[^,^}]+)", RegexOptions.IgnoreCase).Groups["name"].Value;
            String path = Regex.Match(value, @"Path=(?<path>[^,^}]+)", RegexOptions.IgnoreCase).Groups["path"].Value;

            var deviceCfg = (from item in cboDevices.Items.Cast<DeviceConfiguration>()
                          where item.Name == name
                          select item).Single();

            if (deviceCfg == null)
                return;

            cboDevices.SelectedItem = deviceCfg;

            var button = (ButtonDeviceComponent)_device.GetType().GetProperty(path).GetValue(_device, null);

            cboButton.SelectedItem = button;
        }
    }
}
