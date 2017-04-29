using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
        {
            base._customer = customer;
            base._balance = _balance;
            base._interestRate = interestRate;
        }

        public override void DepositMoney(decimal ammount)
        {
            base._balance += ammount;
        }
        public override void WithDraw(decimal ammount)
        {
            Console.WriteLine("You cannot withdraw money from a mortgage account!");
        }
        public override decimal InterestAmmount(int months)
        {
            decimal ammount = 0;
            string customerType = base._customer.typeOfCustomer();
            if (customerType == "individual")
            {
                months -= 6;
                if (months > 0)
                {
                    ammount = base._interestRate * months;
                }
            }
            if (customerType == "company")
            {
                ammount = (base._interestRate/2) * months;
                if (months > 12)
                {
                    ammount += (base._interestRate/2) * (months - 12);
                }
            }
            return ammount;
        }
    }
}
