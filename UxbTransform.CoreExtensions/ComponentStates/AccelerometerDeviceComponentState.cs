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

namespace UxbTransform.UI.ComponentStates
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [DeviceComponentStateUI(typeof(AccelerometerDeviceComponent))]
    public partial class AccelerometerDeviceComponentState : UserControl, IDeviceComponentStateUI
    {
        AccelerometerDeviceComponent _model;

        public AccelerometerDeviceComponentState()
        {
            InitializeComponent();
        }

        public void Initialize(DeviceComponent model)
        {
            _model = model as AccelerometerDeviceComponent;

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
                lblZValue.Text = _model.ZAxis.ToString();
            };

            this.Invoke(a);
        }
    }
}
