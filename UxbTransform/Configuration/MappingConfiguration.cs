using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace UxbTransform.Configuration
{
    public class MappingConfiguration
    {
        [XmlElement("Gesture")]
        public GestureConfiguration Gesture { get; set; }

        [XmlElement("Command")]
        public CommandConfiguration Command { get; set; }

        [XmlIgnore]
        public Gesture GestureInstance { get; set; }

        public MappingConfiguration()
        {
            Gesture = new GestureConfiguration();
            Command = new CommandConfiguration();
        }

        public Gesture BuildGesture()
        {
            GestureInstance = Gesture.Build();
            return GestureInstance;
        }

        public Command BuildCommand()
        {
            return Command.Build();
        }

        public override String ToString()
        {
            if (GestureInstance == null)
                return "Unassigned Mapping";

            return String.Format("User {0} -> {1}", GestureInstance, Command);
        }
    }
}
