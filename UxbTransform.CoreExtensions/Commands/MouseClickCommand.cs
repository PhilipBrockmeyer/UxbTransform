using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MouseKeyboardLibrary;

namespace UxbTransform.Commands
{
    public class MouseClickCommand : Command
    {
        [UserProperty]
        public MouseButton Button { get; set; }

        public override void Execute()
        {
            MouseSimulator.Click(Button);
        }
    }
}
