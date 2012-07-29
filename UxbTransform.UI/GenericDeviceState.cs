using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UxbTransform.UI
{
    public partial class GenericDeviceState : UserControl
    {
        Device _model;
        Device _previousModel;

        IList<IDeviceComponentStateUI> _components;

        public GenericDeviceState()
        {
            InitializeComponent();
        }

        public void Initialize(Device model)
        {
            _model = model;
            _components = new List<IDeviceComponentStateUI>();
            MoveModelToView();
        }

        private void MoveModelToView()
        {           
            pnlDeviceComponents.Controls.Clear();

            if (_previousModel != null)
            {
                _previousModel.DeviceStateChanged -= _model_DeviceStateChanged;
            }

            _previousModel = _model;

            if (_model == null)
            {
                label1.Visible = true;
                return;
            }

            label1.Visible = false;
            BuildComponents();
            _model.DeviceStateChanged += new EventHandler(_model_DeviceStateChanged);
        }

        private void BuildComponents()
        {
            foreach (var dc in DeviceComponentHelper.QueryDeviceComponents(_model))
            {
                IDeviceComponentStateUI ui = null;
                try
                {
                    ui = ServiceLocator.GetDeviceComponentStateUI(dc.GetType());
                }
                catch (InvalidOperationException)
                {
                    continue;
                }

                if (ui != null)
                {
                    _components.Add(ui);
                    ui.Initialize(dc);
                    pnlDeviceComponents.Controls.Add((Control)ui);
                }
            }
        }

        private void UpdateDeviceState()
        {
            if (!_model.IsConnected)
                return;

            foreach (var component in _components)
            {
                component.UpdateState();
            }
        }

        void _model_DeviceStateChanged(object sender, EventArgs e)
        {
            UpdateDeviceState();
        }
    }
}
