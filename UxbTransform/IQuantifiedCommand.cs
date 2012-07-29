using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public interface IQuantifiedCommand
    {
        IEnumerable<String> GetRequiredValues();
        void SetValue(String key, Object value);
    }
}
