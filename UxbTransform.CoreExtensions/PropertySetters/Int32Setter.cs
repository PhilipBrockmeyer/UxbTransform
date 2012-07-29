using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UxbTransform.Configuration;
using System.ComponentModel.Composition;

namespace UxbTransform.UI.PropertySetters
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [PropertySetterUI(typeof(Int32))]
    public partial class Int32Setter : UserControl, IPropertySetterUI
    {
        PropertySetterConfiguration _model;

        public Int32Setter()
        {
            InitializeComponent();
        }

        public String Property { get; set; }

        public void Initialize(PropertySetterConfiguration model)
        {
            _model = model;
            Property = model.Property;
            lblProperty.Text = Property;
        }

        public PropertySetterConfiguration GetValue()
        {
            Int32 value;
            Int32.TryParse(txtInt.Text, out value);
            _model.Value = value.ToString();
            return _model;
        }

        public void SetValue(String value)
        {
            txtInt.Text = value;
        }
    }
}
