using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public class CommandDescriptor
    {
        public String Name { get; set; }
        public Func<Command> CreateCommandInstance { get; set; }
        public String ActionText { get; set; }

        public override String ToString()
        {
            return Name;
        }
    }
}
