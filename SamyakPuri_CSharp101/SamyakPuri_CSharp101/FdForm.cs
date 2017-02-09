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
    public partial class FdForm : Form
    {
        public FdForm()
        {
            InitializeComponent();
            FdFormInitialize();
        }

        FDAccount fdAccount;
        private void FdFormInitialize()
        {
            fdAccount = new FDAccount();
        }
        private void btnOpenMain_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
            this.Close();  
        }

        private void btnFDWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                fdAccount.Withdraw();
                MessageBox.Show(String.Format("Balance: {0}", fdAccount.Balance));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Enter Vailid Amount");
            }
        }
    }
}
