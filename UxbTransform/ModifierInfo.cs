using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public class ModifierInfo
    {
        Lazy<Modifier, IDictionary<String, Object>> _value;

        public ModifierInfo(Lazy<Modifier, IDictionary<String, Object>> value)
        {
            _value = value;
        }

        public String Key { get { return (String)_value.Metadata["Key"]; } }
        public Modifier Modifier { get { return _value.Value; } }

        public override String ToString()
        {
            return Key;
        }
    }
}
