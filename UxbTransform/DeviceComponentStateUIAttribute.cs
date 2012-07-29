using System.ComponentModel.Composition;
using System;
using System.Windows.Forms;

namespace UxbTransform
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DeviceComponentStateUIAttribute : ExportAttribute
    {
        public Type DeviceComponentType { get; private set; }

        public DeviceComponentStateUIAttribute(Type deviceComponentType)
            : base(typeof(IDeviceComponentStateUI))
        {
            DeviceComponentType = deviceComponentType;
        }
    }
}