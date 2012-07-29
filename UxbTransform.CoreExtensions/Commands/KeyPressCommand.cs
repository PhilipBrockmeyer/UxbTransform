using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MouseKeyboardLibrary;

namespace UxbTransform.Commands
{
    /// <summary>
    /// Simulates the press and release of a keyboard key.
    /// </summary>
    /// <remarks>
    /// Up to two modifier keys can be applied to the key stroke which will be pressed in the
    /// order of Modifier1(down), Modifer2(down), Key, Modifier1(up), Modifier2(up).
    /// </remarks>
    public class KeyPressCommand : Command
    {
        /// <summary>
        /// The key to press.
        /// </summary>
        [UserProperty]
        public Keys Key { get; set; }

        /// <summary>
        /// The first modifier key.
        /// </summary>
        /// <remarks>
        /// Use Keys.None for no modifier.
        /// </remarks>
        [UserProperty]
        public Keys Modifier1 { get; set; }

        /// <summary>
        /// The second modifier key.
        /// </summary>
        /// <remarks>
        /// Use Keys.None for no modifier.
        /// </remarks>
        [UserProperty]
        public Keys Modifier2 { get; set; }


        /// <summary>
        /// Executes the command.
        /// </summary>
        public override void Execute()
        {
            if (Modifier1 != Keys.None)
                KeyboardSimulator.KeyDown(Modifier1);

            if (Modifier2 != Keys.None)
                KeyboardSimulator.KeyDown(Modifier2);

            KeyboardSimulator.KeyPress(Key);

            if (Modifier1 != Keys.None)
                KeyboardSimulator.KeyUp(Modifier1);

            if (Modifier2 != Keys.None)
                KeyboardSimulator.KeyUp(Modifier2);
        }
    }
}
