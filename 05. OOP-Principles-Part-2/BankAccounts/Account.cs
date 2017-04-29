using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public abstract class Account
    {
        protected Customer _customer;
        protected decimal _balance;
        protected decimal _interestRate;

        public Customer Customer
        {
            get { return _customer; }
        }
        public decimal Balance
        {
            get { return _balance; }
        }
        public decimal InterestRate
        {
            get { return _interestRate; }
        }

        public abstract void DepositMoney(decimal ammount);
        public abstract void WithDraw(decimal ammount);
        public abstract decimal InterestAmmount(int months);
    }
}
