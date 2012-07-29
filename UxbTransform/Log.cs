using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UxbTransform
{
    public static class Log
    {
        static List<String> _errors;

        static Log()
        {
            _errors = new List<String>();
        }

        public static IEnumerable<String> AsEnumerable()
        {
            return _errors;
        }

        public static void Clear()
        {
            _errors.Clear();
        }

        public static void Add(String message)
        {
            _errors.Add(message);
        }
    }
}
