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
    [DeviceComponentStateUI(typeof(DeltaDeviceComponent))]
    public partial class DeltaDeviceComponentState : UserControl , IDeviceComponentStateUI
    {
        DeltaDeviceComponent _model;

        public DeltaDeviceComponentState()
        {
            InitializeComponent();
        }

        public void Initialize(DeviceComponent model)
        {
            _model = model as DeltaDeviceComponent;
            chkDelta.Text = model.Name;
        }

        public void UpdateState()
        {
            Action a = () =>
            {
                if (_model.Delta != 0)
                    chkDelta.Checked = true;
                else
                    chkDelta.Checked = false;
            };

            this.Invoke(a);
        }
    }
}
