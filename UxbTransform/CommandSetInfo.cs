using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public class CommandSetInfo
    {
        Lazy<CommandSet, IDictionary<String, Object>> _value;
        String _name;
        String _key;

        public CommandSetInfo(Lazy<CommandSet, IDictionary<String, Object>> value)
        {
            _value = value;
            _key = (String)value.Metadata["Key"];
            _name = (String)value.Metadata["Name"];
        }

        public CommandSet CommandSet 
        {
            get
            {
                return _value.Value;
            }
        }

        public String Name { get { return _name; } }
        public String Key { get { return _key; } }

        public override String ToString()
        {
            return _name;
        }
    }
}
