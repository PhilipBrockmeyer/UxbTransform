using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UxbTransform.UI
{
    public partial class LogUI : UserControl, IActivatable
    {
        public LogUI()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            StringBuilder errorText = new StringBuilder();

            foreach (String error in Log.AsEnumerable())
            {
                errorText.AppendLine(error);
            }

            txtErrors.Text = errorText.ToString();
        }
    }
}
