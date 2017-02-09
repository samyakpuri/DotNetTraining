using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SamyakPuri_CSharp101
{
    class FDAccount : IWithdraw, IDeposit
    {
        double _balance;
        bool withdrawTransact, depositTransact;

        public FDAccount()
        {
            _balance = 0;
        }

        public bool Withdraw(double amount)
        {
            if (!withdrawTransact && depositTransact)
            {
                _balance = 0;
                withdrawTransact = true;
                return true;
            }
            return false;
        }

        public bool Deposit(double amount)
        {
            if (!depositTransact)
            {
                _balance = amount;
                depositTransact = true;
                return true;
            }
            return false;
        }

        public bool Deposit()
        {
            return this.Deposit(0);
        }

        public bool Withdraw()
        {
            return this.Withdraw(0);
        }

        public double Balance 
        { 
            get
            {
                return _balance;
            }
        }
    }
}
