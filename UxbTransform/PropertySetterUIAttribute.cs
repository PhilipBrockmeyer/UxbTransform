using System.ComponentModel.Composition;
using System;
using System.Windows.Forms;

namespace UxbTransform
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class PropertySetterUIAttribute : ExportAttribute
    {
        public Type PropertyType { get; private set; }

        public PropertySetterUIAttribute(Type propertyType)
            : base(typeof(IPropertySetterUI))
        {
            PropertyType = propertyType;
        }
    }
}