using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UxbTransform.DeviceComponents;
using System.ComponentModel.Composition;

namespace UxbTransform.UI
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [DeviceComponentStateUI(typeof(ButtonDeviceComponent))]
    public partial class ButtonDeviceComponentState : UserControl, IDeviceComponentStateUI
    {
        ButtonDeviceComponent _model;

        public ButtonDeviceComponentState()
        {
            InitializeComponent();
        }

        public void Initialize(DeviceComponent model)
        {
            _model = model as ButtonDeviceComponent;

            if (_model == null)
                throw new ApplicationException();

            chkButton.Text = _model.Name;
        }

        public void UpdateState()
        {
            Action a = () =>
            {
                if (_model.State == UxbTransform.DeviceComponents.ButtonState.Down)
                    chkButton.Checked = true;
                else
                    chkButton.Checked = false;
            };

            this.Invoke(a);
        }
    }
}
