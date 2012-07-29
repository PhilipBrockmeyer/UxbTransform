using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using MouseKeyboardLibrary;
using System.Windows.Forms;

namespace UxbTransform.Commands
{
    public class MouseMoveCommand : Command, IQuantifiedCommand
    {
        PointF _value;

        public override void Execute()
        {
            Rectangle screenDimensions = Screen.PrimaryScreen.Bounds;
            MouseSimulator.Position = new Point((Int32)((Single)screenDimensions.Width * _value.X), (Int32)((Single)screenDimensions.Height * _value.Y));
        }

        String[] _requiredValues = new String[] { "XPosition", "YPosition" };
        public IEnumerable<String> GetRequiredValues()
        {
            return _requiredValues;
        }

        public void SetValue(String key, Object value)
        {
            if (key == "XPosition")
                _value.X = (Single)value;
            else if (key == "YPosition")
                _value.Y = (Single)value;
        }
    }
}
