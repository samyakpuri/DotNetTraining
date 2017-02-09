using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSHeadStart
{
    interface IAccountWithdraw
    {
        void Withdraw(double amount);
        void duplicate();
    }
 
    interface IAccountDeposit
    {
        void Deposit(double amount);
        void duplicate();
    }

    class CurrentAccount: IAccountWithdraw, IAccountDeposit
    {
        double _balance;

    
        public void Withdraw(double amount)
        {
            _balance -= amount;
        }
        
        public void Deposit(double amount)
        {
            _balance += amount;
        }
        public void duplicate()
        {
 	        
        }

        void IAccountWithdraw.duplicate()
        {

        }

        void IAccountDeposit.duplicate()
        {

        }
    }
}

