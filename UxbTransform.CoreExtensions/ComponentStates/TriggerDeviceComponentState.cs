using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using UxbTransform.CoreExtensions.DeviceComponents;

namespace UxbTransform.CoreExtensions.ComponentStates
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [DeviceComponentStateUI(typeof(TriggerDeviceComponent))]
    public partial class TriggerDeviceComponentState : UserControl, IDeviceComponentStateUI
    {
        TriggerDeviceComponent _model;

        public TriggerDeviceComponentState()
        {
            InitializeComponent();
        }

        public void Initialize(DeviceComponent model)
        {
            _model = model as TriggerDeviceComponent;

            if (_model == null)
                throw new ApplicationException();

            lblName.Text = _model.Name;
        }

        public void UpdateState()
        {
            Action a = () =>
            {
                lblValue.Text = _model.Position.ToString();
            };

            this.Invoke(a);
        }
    }
}
