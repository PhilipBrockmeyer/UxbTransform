using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public interface IServiceLocator
    {
        CommandSet GetCommandSet(String key);
        IEnumerable<CommandSetInfo> GetCommandSets();
        Device GetDevice(String key);
        IDeviceComponentStateUI GetDeviceComponentStateUI(Type componentType);
        IEnumerable<DeviceInfo> GetDevices();
        Gesture GetGesture(String key);
        IEnumerable<GestureInfo> GetGestures();
        Modifier GetModifier(String key);
        IEnumerable<ModifierInfo> GetModifiers();
        IPropertyConverter GetPropertyConverter(Type propertyType);
        IPropertySetterUI GetPropertyUI(Type propertyType);
    }
}
