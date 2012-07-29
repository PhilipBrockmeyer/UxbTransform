using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace UxbTransform.Configuration
{
    public class GestureConfiguration
    {
        [XmlAttribute("type")]
        public String Type { get; set; }

        [XmlArray("Properties")]
        [XmlArrayItem("Set")]
        public List<PropertySetterConfiguration> GestureProperties { get; set; }
        
        [XmlArray("Modifiers")]
        [XmlArrayItem("Modifier")]
        public List<GestureModifierConfiguartion> Modifiers { get; set; }

        public GestureConfiguration()
        {
            Modifiers = new List<GestureModifierConfiguartion>();
            GestureProperties = new List<PropertySetterConfiguration>();
        }

        public Gesture Build()
        {
            if (Type == null)
            {
                Log.Add("No gesture type was specified in the following block:");
                Log.Add(XmlHelper.GetXmlText(this));
                return null;
            }

            Gesture gesture;
            try
            {
                gesture = ServiceLocator.GetGesture(Type);
            }
            catch (InvalidOperationException)
            {
                Log.Add(String.Format("No gesture type named '{0}' was loaded.", Type));
                Log.Add(XmlHelper.GetXmlText(this));
                return null;
            }
            
            if (GestureProperties != null)
            {
                foreach (var prop in GestureProperties)
                {
                    prop.SetProperty(gesture);
                }
            }

            if (Modifiers != null)
            {
                foreach (var mod in Modifiers)
                {
                    gesture.AddModifier(mod.Build());
                }
            }

            return gesture;
        }
    }
}
