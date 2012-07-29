using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition.Primitives;
using System.ComponentModel.Composition;
using UxbTransform.Configuration;
using MouseKeyboardLibrary;

namespace UxbTransform.PropertyConverters
{
    [PartCreationPolicy(CreationPolicy.Shared)]
    [PropertyConverter(typeof(MouseButton))]
    public class KeyboardKeyConverter : IPropertyConverter
    {
        public Object ConvertTo(String value)
        {
            return Enum.Parse(typeof(MouseButton), value);
        }

        public String ConvertFrom(Object value)
        {
            return Enum.GetName(typeof(MouseButton), value);
        }
    }
}
