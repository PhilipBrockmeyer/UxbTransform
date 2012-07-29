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
    public partial class ApplicationManager : UserControl
    {
        Configuration.Configuration _model;

        public ApplicationManager()
        {
            InitializeComponent();
        }

        public void Initialize(Configuration.Configuration model)
        {
            _model = model;

            MoveModelToView();
        }

        private void MoveModelToView()
        {
            lstApplications.Items.Clear();

            foreach (var app in _model.Applications)
            {
                lstApplications.Items.Add(app);
            }

            if (lstApplications.Items.Count > 0)
            {
                lstApplications.SelectedIndex = 0;
            }
        }

        private void SelectApplication()
        {
            ucApplicationMapping.Initialize((ApplicationConfiguration)lstApplications.SelectedItem);
        }

        private void AddApplication()
        {
            ApplicationConfiguration app = new ApplicationConfiguration();
            NewApplication form = new NewApplication();
            form.Initialize(app);
            form.ShowDialog();

            if (!form.IsCanceled)
            {
                _model.AddApplication(app);
                MoveModelToView();
            }

            form.Dispose();
        }

        private void RemoveApplication()
        {
            var app = (ApplicationConfiguration)lstApplications.SelectedItem;
            
            if (app.Name == "Default")
            {
                MessageBox.Show("The default application can not be removed.");
                return;
            }

            _model.RemoveApplication(app);
            MoveModelToView();
        }

        private void ShowApplicationDetails()
        {
            var app = (ApplicationConfiguration)lstApplications.SelectedItem;

            if (app.Name == "Default")
            {
                MessageBox.Show("The default application can not be modified.");
                return;
            }

            EditApplication form = new EditApplication();
            form.Initialize(app);
            form.ShowDialog();

            if (!form.IsCanceled)
            {
                MoveModelToView();
            }

            form.Dispose();
        }

        private void lstApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectApplication();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveApplication();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddApplication();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            ShowApplicationDetails();
        }
    }
}
