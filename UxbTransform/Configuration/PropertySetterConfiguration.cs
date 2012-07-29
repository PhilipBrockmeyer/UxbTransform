using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Reflection;

namespace UxbTransform.Configuration
{
    public class PropertySetterConfiguration
    {
        [XmlAttribute("property")]
        public String Property { get; set; }

        [XmlAttribute("value")]
        public String Value { get; set; }

        public void SetProperty(Object obj)
        {
            PropertyInfo prop = obj.GetType().GetProperty(Property);
            Object value;

            if (prop == null)
            {
                Log.Add(String.Format("No property named {0} was found on {1}", Property, obj));
                Log.Add(XmlHelper.GetXmlText(this));
                return;
            }

            if (typeof(IConvertible).IsAssignableFrom(prop.PropertyType)
                && !typeof(Enum).IsAssignableFrom(prop.PropertyType))
            {
                value = Convert.ChangeType(Value, prop.PropertyType);
            }
            else if (typeof(DeviceComponent).IsAssignableFrom(prop.PropertyType))
            {
                value = new DeviceBinding(Value).DeviceComponent;
            }
            else
            {
                var converter = ServiceLocator.GetPropertyConverter(prop.PropertyType);
                value = converter.ConvertTo(Value);
            }

            if (value == null)
            {
                Log.Add(String.Format("Unable to set value for property {0}", Property));
                Log.Add(XmlHelper.GetXmlText(this));
            }

            prop.SetValue(obj, value, null);
        }
    }
}
