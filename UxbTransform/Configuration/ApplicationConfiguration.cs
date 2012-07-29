using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace UxbTransform.Configuration
{
    public class ApplicationConfiguration
    {
        [XmlAttribute("name")]
        public String Name { get; set; }

        [XmlAttribute("processName")]
        public String ProcessName { get; set; }

        [XmlArray("GestureMappings")]
        [XmlArrayItem("Mapping")]
        public List<MappingConfiguration> GestureMappings { get; set; }

        InputMap _map;

        public ApplicationConfiguration()
        {
            GestureMappings = new List<MappingConfiguration>();
        }

        public InputMap BuildInputMap()
        {
            _map =  new InputMap();
            MapInput();
            return _map;
        }

        public void MapInput()
        {
            foreach (var mapping in GestureMappings)
            {
                Gesture gesture = mapping.BuildGesture();
                Command command = mapping.BuildCommand();

                _map.MapInput(gesture, command);
            }
        }

        public void AddMapping(MappingConfiguration mapping)
        {
            GestureMappings.Add(mapping);
        }

        public void RemoveMapping(MappingConfiguration mapping)
        {
            GestureMappings.Remove(mapping);
        }

        public override String ToString()
        {
            return Name;
        }
    }
}
