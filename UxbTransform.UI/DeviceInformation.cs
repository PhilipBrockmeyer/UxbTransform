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
    public partial class DeviceInformation : UserControl
    {
        DeviceConfiguration _model;

        public DeviceInformation()
        {
            InitializeComponent();
        }

        public void Initialize(DeviceConfiguration model)
        {
            _model = model;

            MoveModelToView();
            pnlRead.BringToFront();
        }

        private void MoveModelToView()
        {
            if (_model != null)
            {
                lblDeviceName.Text = _model.Name;
                lblDeviceType1.Text = _model.Type;
                lblDeviceType2.Text = _model.Type;
                lblIndex.Text = _model.Index.ToString();

                txtDeviceName.Text = _model.Name;
                txtIndex.Text = _model.Index.ToString();

                var device = _model.GetDevice();
                if (device != null)
                {
                    chkIsConnected1.Checked = device.IsConnected;
                    chkIsConnected2.Checked = device.IsConnected;
                }
                else
                {
                    chkIsConnected1.Checked = false;
                    chkIsConnected2.Checked = false;
                }

                btnEdit.Enabled = true;
            }
            else
            {
                lblDeviceName.Text = "No Device Selected";
                lblDeviceType1.Text = "Device Type";
                lblIndex.Text = "No Device";

                btnEdit.Enabled = false;
            }
        }

        private void MoveViewToModel()
        {
            _model.Name = txtDeviceName.Text;

            Int32 index = 0;
            Int32.TryParse(txtIndex.Text, out index);
            _model.Index = index;
        }

        private void Save()
        {
            MoveViewToModel();
            MoveModelToView();
            pnlRead.BringToFront();
        }

        private void Edit()
        {
            pnlEdit.BringToFront();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
