﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using UxbTransform.DeviceComponents;
using UxbTransform.Configuration;
using System.Text.RegularExpressions;

namespace UxbTransform.UI.PropertySetters
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [PropertySetterUI(typeof(DeltaDeviceComponent))]
    public partial class DeltaDeviceComponentSetter : UserControl, IPropertySetterUI
    {
        PropertySetterConfiguration _model;
        Device _device;

        public DeltaDeviceComponentSetter()
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

            if (cboComponent.SelectedItem == null)
                return _model;

            String component = DeviceComponentHelper.GetPropertyName(_device, ((DeltaDeviceComponent)cboComponent.SelectedItem).Name);
            _model.Value = "{DeviceBinding Path=" + component + ", Name=" + ((DeviceConfiguration)cboDevices.SelectedItem).Name + "}";
            return _model;
        }

        private void SelectDevice()
        {
            _device = ServiceLocator.GetDevice(
                        ((DeviceConfiguration)cboDevices.SelectedItem).Type
                      );

            var components = DeviceComponentHelper.QueryDeviceComponents(_device, typeof(DeltaDeviceComponent));

            cboComponent.Items.Clear();

            foreach (var component in components)
                cboComponent.Items.Add(component);
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

            var component = (DeltaDeviceComponent)_device.GetType().GetProperty(path).GetValue(_device, null);

            cboComponent.SelectedItem = component;
        }
    }
}
