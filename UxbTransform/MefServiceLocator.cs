using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition.Hosting;

namespace UxbTransform
{
    public class MefServiceLocator  : IServiceLocator
    {
        CompositionContainer _container;

        public MefServiceLocator(CompositionContainer container)
        {
            _container = container;
        }

        public CommandSet GetCommandSet(String key)
        {
            return _container.GetInstance<CommandSet>(p => (String)p.Metadata["Key"] == key);
        }

        public IEnumerable<CommandSetInfo> GetCommandSets()
        {
            var exports = _container.GetExports<CommandSet, IDictionary<String, Object>>();
            
            foreach (var export in exports)
            {
                yield return new CommandSetInfo(export);
            }
        }

        public Device GetDevice(String key)
        {
            return _container.GetInstance<Device>(p => (String)p.Metadata["Key"] == key);
        }

        public IDeviceComponentStateUI GetDeviceComponentStateUI(Type componentType)
        {
            return _container.GetInstance<IDeviceComponentStateUI>(p => (Type)p.Metadata["DeviceComponentType"] == componentType);
        }

        public IEnumerable<DeviceInfo> GetDevices()
        {
            var exports = _container.GetExports<Device, IDictionary<String, Object>>();

            foreach (var export in exports)
            {
                yield return new DeviceInfo(export);
            }
        }

        public Gesture GetGesture(String key)
        {
            return _container.GetInstance<Gesture>(p => (String)p.Metadata["Key"] == key);
        }

        public IEnumerable<GestureInfo> GetGestures()
        {
            var exports = _container.GetExports<Gesture, IDictionary<String, Object>>();

            foreach (var export in exports)
            {
                yield return new GestureInfo(export);
            }
        }

        public Modifier GetModifier(String key)
        {
            return _container.GetInstance<Modifier>(p => (String)p.Metadata["Key"] == key);
        }

        public IEnumerable<ModifierInfo> GetModifiers()
        {
            var exports = _container.GetExports<Modifier, IDictionary<String, Object>>();

            foreach (var export in exports)
            {
                yield return new ModifierInfo(export);
            }
        }

        public IPropertyConverter GetPropertyConverter(Type propertyType)
        {
            return _container.GetInstance<IPropertyConverter>(p => (Type)p.Metadata["Type"] == propertyType);
        }

        public IPropertySetterUI GetPropertyUI(Type propertyType)
        {
            return _container.GetInstance<IPropertySetterUI>(p => (Type)p.Metadata["PropertyType"] == propertyType);
        }
    }
}
