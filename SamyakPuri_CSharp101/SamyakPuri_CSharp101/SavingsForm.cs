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
    public partial class SavingsForm : Form
    {
        public SavingsForm()
        {
            InitializeComponent();
            SavingsFormInitialize();
        }
        SavingsAccount savingsAccount;
        private void SavingsFormInitialize()
        {
            savingsAccount = new SavingsAccount();
        }

        private void btnSavingsWithdraw_Click(object sender, EventArgs e)
        {
            double amount = 0;
            try
            {
                amount = Convert.ToDouble(txtAmount.Text);
                savingsAccount.Withdraw(amount);
                MessageBox.Show(String.Format("Balance: {0}",savingsAccount.Balance));
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Enter Vailid Amount");
            }
        }

        private void btnOpenMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new MainForm();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void btnSavingsDeposit_Click(object sender, EventArgs e)
        {
            double amount = 0;
            try
            {
                amount = Convert.ToDouble(txtAmount.Text);
                savingsAccount.Deposit(amount);
                MessageBox.Show(String.Format("Balance: {0}", savingsAccount.Balance));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Enter Vailid Amount");
            }
        }
    }
}
