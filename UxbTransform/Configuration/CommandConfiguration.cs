using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace UxbTransform.Configuration
{
    public class CommandConfiguration
    {
        [XmlAttribute("name")]
        public String Name { get; set; }

        [XmlAttribute("commandSet")]
        public String CommandSet { get; set; }

        [XmlArray("Properties")]
        [XmlArrayItem("Set")]
        public List<PropertySetterConfiguration> Properties { get; set; }

        public CommandConfiguration()
        {
            Properties = new List<PropertySetterConfiguration>();
        }

        public Command Build()
        {
            if (CommandSet == null)
            {
                Log.Add("There is a command mapping with no Command Set assigned.");
                Log.Add(XmlHelper.GetXmlText(this));
                return null;
            }

            if (Name == null)
            {
                Log.Add("There is a command mapping with no Command assigned.");
                Log.Add(XmlHelper.GetXmlText(this));
                return null;
            }

            CommandSet commandSet;

            try
            {
                commandSet = ServiceLocator.GetCommandSet(CommandSet);
            }
            catch (InvalidOperationException)
            {
                Log.Add(String.Format("The Command Set '{0}' was not found in any plugin library.", CommandSet));
                Log.Add(XmlHelper.GetXmlText(this));
                return null;
            }

            var descriptor = (CommandDescriptor)commandSet.GetType()
                                        .GetProperty(Name)
                                        .GetValue(commandSet, null);

            Command command = descriptor.CreateCommandInstance();

            if (Properties != null)
            {
                foreach (var prop in Properties)
                {
                    prop.SetProperty(command);
                }
            }

            return command;
        }

        public override String ToString()
        {
            if (CommandSet == null)
                return "Unassigned Command";

            if (Name == null)
                return "Unassigned Command";

            CommandSet set = null;

            try
            {
                set = ServiceLocator.GetCommandSet(CommandSet);
            }
            catch (InvalidOperationException)
            {
                return "Invalid Command";
            }

            return ((CommandDescriptor)set.GetType()
                                        .GetProperty(Name)
                                        .GetValue(set, null)).ActionText;
        }
    }
}
