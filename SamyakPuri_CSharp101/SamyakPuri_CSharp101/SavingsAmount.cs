using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SamyakPuri_CSharp101
{
    class SavingsAccount : IWithdraw, IDeposit
    {
        double _balance,_transactionAmount;

        public SavingsAccount()
        {
            _balance = 0;
            _transactionAmount = 0;
        }

        public bool Withdraw(double amount)
        {
            if (amount < _balance && _transactionAmount < 50000 && _balance >1000)
            {
                _balance -= amount;
                _transactionAmount += amount;
                return true;
            }
            return false;
        }

        public bool Deposit(double amount)
        {
            if (_transactionAmount < 50000)
            {
                _balance += amount;
                _transactionAmount += amount;
                return true;
            }
            return false;
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
