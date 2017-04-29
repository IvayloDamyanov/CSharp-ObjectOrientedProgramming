using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Deposit : Account
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate) 
        {
            base._customer = customer;
            base._balance = balance;
            base._interestRate = interestRate;
        }

        public override void DepositMoney(decimal ammount)
        {
            base._balance += ammount;
        }
        public override void WithDraw(decimal ammount)
        {
            base._balance -= ammount;
        }
        public override decimal InterestAmmount(int months)
        {
            decimal ammount = 0;
            if (base._balance < 0 || base._balance > 1000)
            {
                ammount = base._interestRate * months;
            }
            return ammount;
        }
    }
}
