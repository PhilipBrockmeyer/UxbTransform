using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.Reflection;

namespace UxbTransform
{
    public abstract class CommandSet
    {
        public IEnumerable<CommandDescriptor> FindCommands()
        {
            foreach (PropertyInfo prop in this.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(CommandDescriptor))
                {
                    var value = (CommandDescriptor)prop.GetValue(this, null);
                    value.Name = prop.Name;
                    yield return value;
                }
            }
        }
    }
}
