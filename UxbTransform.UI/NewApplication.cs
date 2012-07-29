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
    public partial class NewApplication : Form
    {
        ApplicationConfiguration _model;

        public Boolean IsCanceled { get; private set; }

        public NewApplication()
        {
            InitializeComponent();
        }

        public void Initialize(ApplicationConfiguration model)
        {
            _model = model;
        }

        private void MoveViewToModel()
        {
            _model.Name = txtName.Text;
            _model.ProcessName = txtProcess.Text;
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

        private void NewApplication_FormClosing(object sender, FormClosingEventArgs e)
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
