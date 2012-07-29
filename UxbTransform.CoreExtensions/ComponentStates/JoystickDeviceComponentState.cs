using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using UxbTransform.DeviceComponents;

namespace UxbTransform.CoreExtensions.ComponentStates
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [DeviceComponentStateUI(typeof(JoystickDeviceComponent))]
    public partial class JoystickDeviceComponentState : UserControl, IDeviceComponentStateUI
    {
        JoystickDeviceComponent _model;

        public JoystickDeviceComponentState()
        {
            InitializeComponent();
        }

        public void Initialize(DeviceComponent model)
        {
            _model = model as JoystickDeviceComponent;

            if (_model == null)
                throw new ApplicationException();

            lblName.Text = _model.Name;
        }

        public void UpdateState()
        {
            Action a = () =>
            {
                lblXValue.Text = _model.XAxis.ToString();
                lblYValue.Text = _model.YAxis.ToString();
            };

            this.Invoke(a);
        }
    }
}
