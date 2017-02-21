using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            ServiceHost host = new ServiceHost(typeof(CalculatorLib.CalculatorService), 
                new Uri[]
                {
                    new Uri("http://localhost:33333"),
                    new Uri("net.tcp://localhost:44444")
                });
            host.AddServiceEndpoint(typeof(CalculatorLib.ICalculator), new BasicHttpBinding(), "Basic");
            host.AddServiceEndpoint(typeof(CalculatorLib.ICalculator), new WSHttpBinding(), "WS");
            host.AddServiceEndpoint(typeof(CalculatorLib.ICalculator), new NetTcpBinding(), "Tcp");

            host.Description.Behaviors.Add(new ServiceMetadataBehavior() 
            { 
                HttpGetEnabled=true
            });

            host.Open();
        }
    }
}
