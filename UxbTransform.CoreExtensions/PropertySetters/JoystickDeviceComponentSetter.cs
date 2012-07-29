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

namespace UxbTransform.CoreExtensions.PropertySetters
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [PropertySetterUI(typeof(JoystickDeviceComponent))]
    public partial class JoystickDeviceComponentSetter : DeviceComponentSetter<JoystickDeviceComponent>
    {
        public JoystickDeviceComponentSetter()
        {
            InitializeComponent();
        }
    }
}
