using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UxbTransform.Configuration;

namespace UxbTransform.UI
{
    public partial class ModifierDetails : UserControl
    {
        GestureModifierConfiguartion _model;

        public GestureModifierConfiguartion Model
        {
            get { return _model; }
        }

        public ModifierDetails()
        {
            InitializeComponent();
        }

        public void Initialize(GestureModifierConfiguartion model)
        {
            _model = model;

            MoveModelToView();
        }

        public void MoveModelToView()
        {
            SetModifier();
            SetProperties();         
        }

        public void MoveViewToModel()
        {
            List<PropertySetterConfiguration> setters = new List<PropertySetterConfiguration>();
            foreach (IPropertySetterUI item in pnlProperties.Controls)
            {
                setters.Add(item.GetValue());
            }


            if (cboModifier.SelectedItem == null)
                _model.Type = null;
            else
                _model.Type = ((ModifierInfo)cboModifier.SelectedItem).Key;

            _model.Properties = setters;

            if (radRequired.Checked)
                _model.Modification = ModificationBehvaior.Required;
            else
                _model.Modification = ModificationBehvaior.Cancel;
        }

        private void SetModifier()
        {
            FillModifierTypes();

            if (_model.Type == null)
                return;

            var modifier = (from item in cboModifier.Items.Cast<ModifierInfo>()
                           where item.Key == _model.Type
                           select item).FirstOrDefault();

            if (modifier == null)
                return;

            cboModifier.SelectedItem = modifier;
        }

        private void SetProperties()
        {
            foreach (IPropertySetterUI setter in pnlProperties.Controls.Cast<IPropertySetterUI>())
            {
                var prop = _model.Properties.Where(p => p.Property == setter.Property).Single();
                setter.SetValue(prop.Value);
            }
        }

        private void FillModifierTypes()
        {
            var modifiers = ServiceLocator.GetModifiers();

            cboModifier.Items.Clear();

            foreach (var modifier in modifiers)
                cboModifier.Items.Add(modifier);
        }

        private void FillProperties()
        {
            Modifier modifier = ((ModifierInfo)cboModifier.SelectedItem).Modifier;

            pnlProperties.Controls.Clear();

            foreach (var prop in modifier.GetType().GetProperties())
            {
                if (prop.GetCustomAttributes(typeof(UserPropertyAttribute), true).Count() == 0)
                    continue;

                var setterControl = ServiceLocator.GetPropertyUI(prop.PropertyType);

                PropertySetterConfiguration setterConfig = new PropertySetterConfiguration();
                setterConfig.Property = prop.Name;
                setterConfig.Value = null;
                setterControl.Initialize(setterConfig);
                pnlProperties.Controls.Add((Control)setterControl);
            }
        }

        private void cboModifier_SelectedIndexChanged_1(Object sender, EventArgs e)
        {
            FillProperties();
        }
    }
}
