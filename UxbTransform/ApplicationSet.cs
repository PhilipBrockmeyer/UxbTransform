using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UxbTransform.Configuration;
using System.Timers;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace UxbTransform
{
    public class ApplicationSet
    {
        String _currentApp;
        Timer _timer;

        public IDictionary<String, InputMap> _mappings;

        public ApplicationSet()
        {
            _mappings = new Dictionary<String, InputMap>();
            _timer = new Timer(1000);
            _currentApp = String.Empty;
            _timer.Start();
            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
        }

        public void HandleInput()
        {
            if (_mappings.ContainsKey("ALL"))
                _mappings["ALL"].Update();

            if (!_mappings.ContainsKey(_currentApp))
                return;

            _mappings[_currentApp].Update();
        }

        public void AddApplication(String processName, InputMap mapping)
        {
            _mappings.Add(processName, mapping);
        }

        void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _currentApp = GetActiveProcessName();
        }

        private static string GetActiveProcessName()
        {
            var hWnd = GetForegroundWindow();
            Int32 pid;
            GetWindowThreadProcessId(hWnd, out pid);
            Process p = Process.GetProcessById(pid);
            return p.ProcessName;
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out Int32 lpdwProcessId);
    }
}
