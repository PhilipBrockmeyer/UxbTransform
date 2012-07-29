using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public interface IQuantifiedGesture
    {
        Boolean HasValue(String key);
        Object GetValue(String key);
    }
}
