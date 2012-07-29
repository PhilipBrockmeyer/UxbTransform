using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace UxbTransform
{
    public static class XmlHelper
    {
        public static String GetXmlText(Object obj)
        {
            String xml = String.Empty;
            XmlSerializer xs = new XmlSerializer(obj.GetType());
            using (StringWriter sw = new StringWriter())
            {
                xs.Serialize(sw, obj);
                xml = sw.GetStringBuilder().ToString();
            }

            return xml;
        }
    }
}
