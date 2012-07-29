using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UxbTransform.CoreExtensions.DeviceComponents;
using System.ComponentModel.Composition;

namespace UxbTransform.CoreExtensions.PropertySetters
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [PropertySetterUI(typeof(TriggerDeviceComponent))]
    public partial class TriggerDeviceComponentSetter : DeviceComponentSetter<TriggerDeviceComponent>
    {
        public TriggerDeviceComponentSetter()
        {
            InitializeComponent();
        }
    }
}
