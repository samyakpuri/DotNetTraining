using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamyakPuri_CSharp101
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSavingsAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            var savingsForm = new SavingsForm();
            savingsForm.Closed += (s, args) => this.Close();
            savingsForm.Show();
        }

        private void btnFDAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FdForm = new FdForm();
            FdForm.Closed += (s, args) => this.Close();
            FdForm.Show();
        }
    }
}
