using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public static class DeviceComponentHelper
    {
        public static IEnumerable<DeviceComponent> QueryDeviceComponents(Object obj)
        {
            return QueryDeviceComponents(obj, typeof(DeviceComponent));
        }

        public static IEnumerable<DeviceComponent> QueryDeviceComponents(Object obj, Type componentType)
        {
            if (!typeof(DeviceComponent).IsAssignableFrom(componentType))
                throw new ApplicationException("The requested type was not a component type.");

            var components = new List<DeviceComponent>();

            var props = obj.GetType().GetProperties();
            foreach (var prop in props)
            {
                if (componentType.IsAssignableFrom(prop.PropertyType))
                    components.Add((DeviceComponent)prop.GetValue(obj, null));
            }

            return components.AsEnumerable();
        }

        public static String GetPropertyName(Object obj, String componentName)
        {
            var props = obj.GetType().GetProperties();
            foreach (var prop in props)
            {
                if (typeof(DeviceComponent).IsAssignableFrom(prop.PropertyType))
                {
                    var component = (DeviceComponent)prop.GetValue(obj, null);
                    if (component.Name == componentName)
                        return prop.Name;
                }
            }

            return null;
        }
    }
}
