using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace UxbTransform.UI
{
    public partial class XmlUI : UserControl, IActivatable 
    {
        public XmlUI()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Configuration.Configuration));
            StringWriter sw = new StringWriter();
            xs.Serialize(sw, Configuration.Configuration.Current);
            txtXml.Text = sw.GetStringBuilder().ToString();
        }
    }
}
