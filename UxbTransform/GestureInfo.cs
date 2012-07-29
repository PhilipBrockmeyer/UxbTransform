using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public class GestureInfo
    {
        Lazy<Gesture, IDictionary<String, Object>> _value;

        public GestureInfo(Lazy<Gesture, IDictionary<String, Object>> value)
        {
            _value = value;
        }

        public String Key { get { return (String)_value.Metadata["Key"]; } }
        public Gesture Gesture { get { return _value.Value; } }

        public override String ToString()
        {
            return Key;
        }
    }
}
