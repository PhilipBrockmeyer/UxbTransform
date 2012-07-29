using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using System.ComponentModel.Composition.Hosting;
using System.Xml.Serialization;
using System.IO;
using UxbTransform.UI;
using UxbTransform.Configuration;

namespace UxbTransform
{
    public partial class Form1 : Form, INotifier
    {
        ApplicationSet _apps;
        DeviceManager _dm;
        TransformationModel _model;
        CompositionContainer _container;
        Configuration.Configuration _cfg;

        public Form1()
        {
            InitializeComponent();

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            var internalCatalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var pluginCatalog = new DirectoryCatalog("Extensions");
            var aggCatalog = new AggregateCatalog(internalCatalog, pluginCatalog);
            _container = new CompositionContainer(aggCatalog);

            ServiceLocator.SetServiceLocator(new MefServiceLocator(_container));

            ConfigurationReader cr = new ConfigurationReader();
            _cfg = cr.GetConfiguration();
            ApplyConfiguration();
            
            ucDeviceManagement.Initialize(_cfg);
            ucApplicationManager.Initialize(_cfg);

            System.Windows.Forms.Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
        }

        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Notify("Error", e.Exception.Message);
            Log.Add(e.Exception.ToString());
        }

        void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (_dm != null)
            {
                _dm.DisconnectDevices();
                _dm.DeviceStateChanged -= d_DeviceStateChanged;
            }
        }

        public void Notify(String title, String message)
        {
            ntfNotifyIcon.ShowBalloonTip(2000, title, message, ToolTipIcon.Error);
        }

        private void Save()
        {
            ApplyConfiguration();

            XmlSerializer xs = new XmlSerializer(typeof(Configuration.Configuration));

            String path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "UxbTransform/Config.xml");

            using (Stream file = File.Create(path))
            {
                xs.Serialize(file, _cfg);
            }
        }

        private void ApplyConfiguration()
        {
            if (_dm != null)
            {
                _dm.DisconnectDevices();
                _dm.DeviceStateChanged -= d_DeviceStateChanged;
            }

            _model = _cfg.Configure();
            
            _dm = new DeviceManager(_model.Devices, this);
            _dm.ConnectDevices();
            _apps = _model.Applications;
            _dm.DeviceStateChanged += new EventHandler(d_DeviceStateChanged);
        }

        void d_DeviceStateChanged(object sender, EventArgs e)
        {
            _apps.HandleInput();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.WindowState = FormWindowState.Minimized;
                e.Cancel = true;
                return;
            }

            _dm.DisconnectDevices();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Minimized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void reconnectToDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dm.ReconnectDevices();
        }

        private void btnApplyChanges_Click(object sender, EventArgs e)
        {
            ApplyConfiguration();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IActivatable activation =  tabControl1.TabPages[tabControl1.SelectedIndex].Controls[0] as IActivatable;

            if (activation != null)
                activation.Activate();
        }
    }
}
