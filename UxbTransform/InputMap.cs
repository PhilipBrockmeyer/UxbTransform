using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace UxbTransform
{
    public class InputMap
    {
        IDictionary<Gesture, Command> _mappings;

        public InputMap()
        {
            _mappings = new Dictionary<Gesture, Command>();
        }

        public void MapInput(Gesture gesture, Command command)
        {
            if (gesture == null)
                return;

            if (command == null)
                return;

            _mappings.Add(gesture, command);
            gesture.Gestured += new EventHandler(gesture_Gestured);
        }

        void gesture_Gestured(Object sender, EventArgs e)
        {
            Command c = _mappings[(Gesture)sender];

            IQuantifiedCommand qc = c as IQuantifiedCommand;
            if (qc != null)
            {
                var qg = sender as IQuantifiedGesture;

                if (qg == null)
                {
                    Log.Add("A command is mapped to a gesture that does not provide the neccessary inputs.");
                    return;
                }

                foreach (var key in ((IQuantifiedCommand)c).GetRequiredValues())
                {
                    qc.SetValue(key, ((IQuantifiedGesture)sender).GetValue(key));
                }
            }

            c.Execute();
        }

        public void Update()
        {
            foreach (var gesture in _mappings.Keys)
            {
                gesture.Update();
            }
        }
    }
}
