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
    public partial class InputDetails : UserControl
    {
        GestureConfiguration _model;

        public InputDetails()
        {
            InitializeComponent();
        }

        public void Initialize(GestureConfiguration model)
        {
            _model = model;

            MoveModelToView();
        }

        public void MoveModelToView()
        {
            if (_model == null)
            {
                Clear();
                return;
            }

            SetGestureType();
            SetProperties();         
        }

        public void MoveViewToModel()
        {
            List<PropertySetterConfiguration> setters = new List<PropertySetterConfiguration>();
            foreach (IPropertySetterUI item in pnlProperties.Controls)
            {
                setters.Add(item.GetValue());
            }

            if (cboGestureType.SelectedItem == null)
                _model.Type = null;
            else
                _model.Type = ((GestureInfo)cboGestureType.SelectedItem).Key;

            _model.GestureProperties = setters;
        }

        private void Clear()
        {
            cboGestureType.Items.Clear();
            pnlProperties.Controls.Clear();
        }

        private void SetGestureType()
        {
            FillGestureTypes();

            if (_model.Type == null)
                return;

            var gesture = (from item in cboGestureType.Items.Cast<GestureInfo>()
                           where item.Key == _model.Type
                           select item).FirstOrDefault();

            if (gesture == null)
                return;

            cboGestureType.SelectedItem = gesture;
        }

        private void SetProperties()
        {
            foreach (IPropertySetterUI setter in pnlProperties.Controls.Cast<IPropertySetterUI>())
            {
                var prop = _model.GestureProperties.Where(p => p.Property == setter.Property).Single();
                setter.SetValue(prop.Value);
            }
        }

        private void FillGestureTypes()
        {
            var gestureTypes = ServiceLocator.GetGestures();

            cboGestureType.Items.Clear();

            foreach (var gestureType in gestureTypes)
                cboGestureType.Items.Add(gestureType);
        }

        private void FillProperties()
        {
            Gesture gesture = ((GestureInfo)cboGestureType.SelectedItem).Gesture;

            pnlProperties.Controls.Clear();

            foreach (var prop in gesture.GetType().GetProperties())
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

        private void cboGestureType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillProperties();
        }
    }
}
