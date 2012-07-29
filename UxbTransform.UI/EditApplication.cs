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
    public partial class EditApplication : Form
    {
        ApplicationConfiguration _model;

        public Boolean IsCanceled { get; private set; }

        public EditApplication()
        {
            InitializeComponent();
        }

        public void Initialize(ApplicationConfiguration model)
        {
            _model = model;

            MoveModelToView();
        }

        private void MoveModelToView()
        {
            txtName.Text = _model.Name;
            txtProcess.Text = _model.ProcessName;
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

        private void EditApplication_FormClosing(object sender, FormClosingEventArgs e)
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
