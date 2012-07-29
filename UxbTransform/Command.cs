using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public abstract class Command
    {
        public Boolean AllowUserProperties { get; set; }
        public abstract void Execute();

        public Command()
        {
            AllowUserProperties = true;
        }
    }
}
