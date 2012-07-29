using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace UxbTransform.Configuration
{
    public class ConfigurationReader
    {
        String _configFile;

        public ConfigurationReader() : this("Default.xml") { }

        public ConfigurationReader(String configFile)
        {
            _configFile = configFile;
            String path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "UxbTransform");
            Directory.CreateDirectory(path.ToString());
            path = Path.Combine(path, "Config.xml");
            _configFile = path.ToString();

            if (!File.Exists(path.ToString()))
                File.Copy("Default.xml", path.ToString());
        }

        public Configuration GetConfiguration()
        {
            //File.Exists(

            XmlSerializer xs = new XmlSerializer(typeof(Configuration));
            Configuration cfg;

            using (var file = File.OpenRead(_configFile))
            {
                cfg = (Configuration)xs.Deserialize(file);
            }

            return cfg;
        }
    }
}
