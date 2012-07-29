using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public interface INotifier
    {
        void Notify(String title, String message);
    }
}
