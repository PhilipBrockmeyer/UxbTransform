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
    [PropertySetterUI(typeof(Keys))]
    public partial class KeyboardKeySetter : UserControl, IPropertySetterUI
    {
        public String Property { get; private set; }

        PropertySetterConfiguration _model;

        public KeyboardKeySetter()
        {
            InitializeComponent();
        }

        public void Initialize(PropertySetterConfiguration model)
        {
            _model = model;
            Property = model.Property;

            foreach (var key in Enum.GetNames(typeof(Keys)))
                cboKey.Items.Add(key);

            lblProperty.Text = Property;
        }

        public PropertySetterConfiguration GetValue()
        {
            _model.Value = (String)cboKey.SelectedItem;
            return _model;
        }

        public void SetValue(String value)
        {
            cboKey.SelectedItem = value;
        }
    }
}
