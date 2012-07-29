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

namespace UxbTransform.UI
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [DeviceComponentStateUI(typeof(PositionalDeviceComponent))]
    public partial class PositionalDeviceComponentState : UserControl, IDeviceComponentStateUI
    {
        PositionalDeviceComponent _model;

        public PositionalDeviceComponentState()
        {
            InitializeComponent();
        }

        public void Initialize(DeviceComponent model)
        {
            _model = model as PositionalDeviceComponent;

            if (_model == null)
                throw new ApplicationException();

            lblName.Text = _model.Name;
        }

        public void UpdateState()
        {
            Action a = () =>
                {
                    lblXValue.Text = _model.X.ToString();
                    lblYValue.Text = _model.Y.ToString();
                };

            this.Invoke(a);
        }
    }
}
