using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MouseKeyboardLibrary;

namespace UxbTransform.Commands
{
    public class SwitchCommand : Command, IQuantifiedCommand
    {
        Int32 _delta;

        [UserProperty]
        public Keys SwitchKey { get; set; }

        [UserProperty]
        public Keys ModifierKey { get; set; }

        [UserProperty]
        public Keys ReverseModifierKey { get; set; }
        
        public override void Execute()
        {
            if (ModifierKey != Keys.None)
                KeyboardSimulator.KeyDown(ModifierKey);

            if (_delta < 0)
                KeyboardSimulator.KeyDown(ReverseModifierKey);

            KeyboardSimulator.KeyDown(SwitchKey);

            if (_delta < 0)
                KeyboardSimulator.KeyUp(ReverseModifierKey);

            if (ModifierKey != Keys.None)
                KeyboardSimulator.KeyUp(ModifierKey);
        }

        String[] _requiredValues = new String[] { "DeltaValue" };
        public IEnumerable<String> GetRequiredValues()
        {
            return _requiredValues;
        }

        public void SetValue(String key, Object value)
        {
            if (key == "DeltaValue")
                _delta = (Int32)value;
        }
    }
}
