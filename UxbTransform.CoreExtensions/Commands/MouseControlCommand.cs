using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MouseKeyboardLibrary;

namespace UxbTransform.CoreExtensions.Commands
{
    public class MouseControlCommand : Command, IQuantifiedCommand
    {
        private readonly Single speed = 6.0f;

        Single _xaxis;
        Single _yaxis;

        public override void Execute()
        {
            MouseSimulator.X += (Int32)(speed * _xaxis);
            MouseSimulator.Y += (Int32)(speed * _yaxis);
        }

        String[] _requiredValues = new String[] { "XAxis", "YAxis" };
        public IEnumerable<String> GetRequiredValues()
        {
            return _requiredValues;
        }

        public void SetValue(String key, Object value)
        {
            if (key == "XAxis")
                _xaxis = (Single)value;

            if (key == "YAxis")
                _yaxis = (Single)value;
        }
    }
}
