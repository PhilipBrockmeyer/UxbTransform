using System.ComponentModel.Composition;
using System;

namespace UxbTransform
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class CommandSetAttribute : ExportAttribute
    {
        public String Name { get; private set; }
        public String Key { get; private set; }
        
        public CommandSetAttribute(String name, String key)
            : base(typeof(CommandSet)) 
        {
            Name = name;
            Key = key;
        }
    }
}