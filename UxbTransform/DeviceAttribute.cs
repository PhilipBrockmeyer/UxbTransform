using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace UxbTransform
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DeviceAttribute : ExportAttribute
    {
        public String Name { get; private set; }
        public String Key { get; private set; }

        public DeviceAttribute(String name, String key)
            : base(typeof(Device))
        {
            Name = name;
            Key = key;
        }
    }
}
