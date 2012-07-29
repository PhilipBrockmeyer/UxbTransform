using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace UxbTransform
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ModifierAttribute : ExportAttribute
    {
        public String Key { get; private set; }

        public ModifierAttribute(String key)
            : base(typeof(Modifier))
        {
            Key = key;
        }
    }
}
