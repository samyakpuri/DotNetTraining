using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DllDisplay
{
    public partial class ParameterControl : UserControl
    {

        private ParameterControl()
        {
            InitializeComponent();
        }

        public ParameterControl(string parameterName, string parameterType)
        {
            InitializeComponent();
            lblParameterName.Text = parameterName;
            lblParameterType.Text = parameterType;
        }
        
        public string ParameterValue
        {
            get
            {
                return txtParameterValue.Text;
            }
        }
        
        public string ParameterType
        {
            get
            {
                return lblParameterType.Text;
            }
        }
    }
}
