using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace UxbTransform
{
    public abstract class Gesture
    {
        IList<Modifier> _modifiers;
        IList<Device> _deviceDependencies;
        Boolean _dependenciesLoaded;

        public abstract Boolean IsGestureActivated();

        public event EventHandler Gestured;

        public Gesture()
        {
            _modifiers = new List<Modifier>();
            _dependenciesLoaded = false;
            _deviceDependencies = new List<Device>();
        }

        public void Update()
        {
            if (!_dependenciesLoaded)
                FindDeviceDependencies();

            foreach (var device in _deviceDependencies)
            {
                if (!device.IsConnected)
                    return;
            }

            foreach (var mod in _modifiers)
            {
                if (!mod.AllowsGesture())
                    return;
            }

            if (!IsGestureActivated())
                return;

            OnGestured();
        }

        public void AddModifier(Modifier modifier)
        {
            _modifiers.Add(modifier);
        }

        protected void OnGestured()
        {
            if (Gestured != null)
                Gestured(this, EventArgs.Empty);
        }

        private void FindDeviceDependencies()
        {
            // Add direct dependencies.
            foreach (var component in DeviceComponentHelper.QueryDeviceComponents(this))
            {
                if (!_deviceDependencies.Contains(component.Owner))
                {
                    _deviceDependencies.Add(component.Owner);
                }
            }
        }
    }
}
