using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UxbTransform.Configuration;

namespace UxbTransform
{
    public interface IPropertySetterUI
    {
        String Property { get; }

        void Initialize(PropertySetterConfiguration model);
        PropertySetterConfiguration GetValue();
        void SetValue(String value);
    }
}
