using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UxbTransform.Configuration;

namespace UxbTransform.UI
{
    public partial class NewDevice : Form
    {
        DeviceConfiguration _model;

        public Boolean IsCanceled { get; private set; }

        public NewDevice()
        {
            InitializeComponent();
        }

        public void Initialize(DeviceConfiguration model)
        {
            _model = model;

            var deviceTypes = ServiceLocator.GetDevices();

            foreach (var item in deviceTypes)
            {
                cboDeviceType.Items.Add(item);
            }

            if (cboDeviceType.Items.Count == 0)
                throw new ApplicationException("No device types were found.");

            cboDeviceType.SelectedIndex = 0;
        }

        private void MoveViewToModel()
        {
            _model.Type = ((DeviceInfo)cboDeviceType.SelectedItem).Key;
            _model.Name = txtName.Text;
            Int32 index = 0;
            Int32.TryParse(txtIndex.Text, out index);
            _model.Index = index;
        }

        private void Save()
        {
            IsCanceled = false;
            MoveViewToModel();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void NewDevice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                IsCanceled = true;
                e.Cancel = true;
                this.Hide();
            }            
        }
    }
}
