using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace UxbTransform.Configuration
{
    public class GestureModifierConfiguartion
    {
        [XmlAttribute("type")]
        public String Type { get; set; }

        [XmlAttribute("behavior")]
        public ModificationBehvaior Modification { get; set; }

        [XmlArray("Properties")]
        [XmlArrayItem("Set")]
        public List<PropertySetterConfiguration> Properties { get; set; }

        public GestureModifierConfiguartion()
        {
            Properties = new List<PropertySetterConfiguration>();
        }

        public Modifier Build()
        {
            if (Type == null)
            {
                Log.Add(String.Format("A gesture modifier was created without a type"));
                Log.Add(XmlHelper.GetXmlText(this));
                return null;
            }

            var modifier = ServiceLocator.GetModifier(Type);

            modifier.Behavior = Modification;

            foreach (var prop in Properties)
            {
                prop.SetProperty(modifier);
            }

            return modifier;
        }
    }
}
