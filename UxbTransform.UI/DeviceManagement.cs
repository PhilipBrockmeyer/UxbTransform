using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UxbTransform.Configuration;

namespace UxbTransform.UI
{
    public partial class DeviceManagement : UserControl
    {
        Configuration.Configuration _model;

        public DeviceManagement()
        {
            InitializeComponent();
        }

        public void Initialize(Configuration.Configuration model)
        {
            _model = model;

            MoveModelToView();
        }

        public void MoveModelToView()
        {
            lstDevices.Items.Clear();

            foreach (var device in _model.Devices)
            {
                lstDevices.Items.Add(device);
            }

            if (lstDevices.Items.Count > 0)
            {
                lstDevices.SelectedIndex = 0;
            }
        }

        private void SelectDevice()
        {
            DeviceConfiguration deviceConfig = lstDevices.SelectedItem as DeviceConfiguration;
            ucDeviceInformation.Initialize(deviceConfig);

            if (deviceConfig != null)
            {
                Device device = deviceConfig.GetDevice();

                ucDeviceState.Initialize(device);

                if (device == null)
                    grpState.Text = "State (Not Connected)";
                else
                {
                    if (device.IsConnected)
                        grpState.Text = "State";
                    else
                        grpState.Text = "State (Not Connected)";
                }
            }
            else
            {
                grpState.Text = "State (Not Connected)";
                ucDeviceState.Initialize(null);
            }
        }


        private void AddDevice()
        {
            DeviceConfiguration device = new DeviceConfiguration();
            NewDevice form = new NewDevice();
            form.Initialize(device);
            form.ShowDialog();

            if (!form.IsCanceled)
            {
                _model.AddDevice(device);
                MoveModelToView();
            }

            form.Dispose();
        }

        private void RemoveDevice()
        {
            _model.RemoveDevice((DeviceConfiguration)lstDevices.SelectedItem);
            MoveModelToView();            
        }

        private void lstDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectDevice();
        }

        private void btnRemoveDevice_Click(object sender, EventArgs e)
        {
            RemoveDevice();
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            AddDevice();
        }
    }
}
