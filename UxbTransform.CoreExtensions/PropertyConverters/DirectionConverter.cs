using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace UxbTransform.PropertyConverters
{
    [PartCreationPolicy(CreationPolicy.Shared)]
    [PropertyConverter(typeof(Direction))]
    public class DirectionConverter : IPropertyConverter
    {
        public Object ConvertTo(String value)
        {
            if (value == null)
            {
                Log.Add("A null value was used for a direction.");
                return null;
            }

            return Enum.Parse(typeof(Direction), value);
        }

        public String ConvertFrom(Object value)
        {
            return Enum.GetName(typeof(Direction), value);
        }
    }
}
