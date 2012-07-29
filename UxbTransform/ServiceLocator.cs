using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public static class ServiceLocator
    {
        static IServiceLocator _serviceLocator;

        public static void SetServiceLocator(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public static CommandSet GetCommandSet(String key)
        {
            if (_serviceLocator == null)
                throw new ApplicationException("No service locator has been set.");

            return _serviceLocator.GetCommandSet(key);
        }

        public static IEnumerable<CommandSetInfo> GetCommandSets()
        {
            if (_serviceLocator == null)
                throw new ApplicationException("No service locator has been set.");

            return _serviceLocator.GetCommandSets();
        }

        public static Device GetDevice(String key)
        {
            if (_serviceLocator == null)
                throw new ApplicationException("No service locator has been set.");

            return _serviceLocator.GetDevice(key);
        }

        public static IDeviceComponentStateUI GetDeviceComponentStateUI(Type componentType)
        {
            if (_serviceLocator == null)
                throw new ApplicationException("No service locator has been set.");

            return _serviceLocator.GetDeviceComponentStateUI(componentType);
        }

        public static IEnumerable<DeviceInfo> GetDevices()
        {
            if (_serviceLocator == null)
                throw new ApplicationException("No service locator has been set.");

            return _serviceLocator.GetDevices();
        }

        public static Gesture GetGesture(String key)
        {
            if (_serviceLocator == null)
                throw new ApplicationException("No service locator has been set.");

            return _serviceLocator.GetGesture(key);
        }

        public static IEnumerable<GestureInfo> GetGestures()
        {
            if (_serviceLocator == null)
                throw new ApplicationException("No service locator has been set.");

            return _serviceLocator.GetGestures();
        }

        public static Modifier GetModifier(String key)
        {
            if (_serviceLocator == null)
                throw new ApplicationException("No service locator has been set.");

            return _serviceLocator.GetModifier(key);
        }

        public static IEnumerable<ModifierInfo> GetModifiers()
        {
            if (_serviceLocator == null)
                throw new ApplicationException("No service locator has been set.");

            return _serviceLocator.GetModifiers();
        }

        public static IPropertyConverter GetPropertyConverter(Type propertyType)
        {
            if (_serviceLocator == null)
                throw new ApplicationException("No service locator has been set.");

            return _serviceLocator.GetPropertyConverter(propertyType);
        }

        public static IPropertySetterUI GetPropertyUI(Type propertyType)
        {
            if (_serviceLocator == null)
                throw new ApplicationException("No service locator has been set.");

            return _serviceLocator.GetPropertyUI(propertyType);
        }
    }
}
