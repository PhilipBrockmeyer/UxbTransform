using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition.Primitives;
using System.ComponentModel.Composition;
using UxbTransform.Configuration;
using System.Windows.Forms;

namespace UxbTransform.Keyboard.PropertyConverters
{
    [PartCreationPolicy(CreationPolicy.Shared)]
    [PropertyConverter(typeof(System.Windows.Forms.Keys))]
    public class MouseButtonConverter : IPropertyConverter
    {
        public object ConvertTo(String value)
        {
            if (value == null)
                return Keys.None;

            return Enum.Parse(typeof(System.Windows.Forms.Keys), value);
        }

        public String ConvertFrom(Object value)
        {
            if (value == null)
                return null;

            return Enum.GetName(typeof(Keys), value);
        }
    }
}
