using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MouseKeyboardLibrary;

namespace UxbTransform.Commands
{
    public class KeyMapCommand : Command, IQuantifiedCommand
    {
        Boolean _pressed;

        [UserProperty]
        public Keys Key { get; set; }

        public override void Execute()
        {
            if (_pressed)
                KeyboardSimulator.KeyDown(Key);
            else
                KeyboardSimulator.KeyUp(Key);
        }

        String[] _requiredValues = new String[] { "ButtonState" };
        public IEnumerable<String> GetRequiredValues()
        {
            return _requiredValues;
        }

        public void SetValue(String key, Object value)
        {
            if (key == "ButtonState")
                _pressed = (Boolean)value;
        }
    }
}
