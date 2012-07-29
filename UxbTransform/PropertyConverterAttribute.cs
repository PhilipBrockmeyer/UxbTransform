using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace UxbTransform
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class PropertyConverterAttribute : ExportAttribute
    {
        public Type Type { get; private set; }

        public PropertyConverterAttribute(Type type)
            : base(typeof(IPropertyConverter))
        {
            Type = type;
        }
    }
}
