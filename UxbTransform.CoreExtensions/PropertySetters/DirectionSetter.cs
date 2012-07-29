using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using UxbTransform.Configuration;

namespace UxbTransform.UI.PropertySetters
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [PropertySetterUI(typeof(Direction))]
    public partial class DirectionSetter : UserControl, IPropertySetterUI
    {
        public String Property { get; private set; }

        PropertySetterConfiguration _model;

        public DirectionSetter()
        {
            InitializeComponent();
        }

        public void Initialize(PropertySetterConfiguration model)
        {
            _model = model;
            Property = model.Property;

            foreach (var key in Enum.GetNames(typeof(Direction)))
                cboDirection.Items.Add(key);

        }

        public PropertySetterConfiguration GetValue()
        {
            _model.Value = (String)cboDirection.SelectedItem;
            return _model;
        }

        public void SetValue(String value)
        {
            cboDirection.SelectedItem = value;
        }
    }
}
