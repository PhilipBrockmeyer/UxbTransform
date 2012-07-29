using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using UxbTransform.Configuration;

namespace UxbTransform
{
    public interface IPropertyConverter
    {
        Object ConvertTo( String value);
        String ConvertFrom(Object value);
    }
}
