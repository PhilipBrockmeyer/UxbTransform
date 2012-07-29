using System.ComponentModel.Composition;
using System;
namespace UxbTransform
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class GestureAttribute : ExportAttribute
    {
        public String Key { get; private set; }

        public GestureAttribute(String key)
            : base(typeof(Gesture))
        {
            Key = key;
        }
    }
}

