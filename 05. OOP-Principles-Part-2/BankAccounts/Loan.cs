using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
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
            Console.WriteLine("You cannot withdraw money from a loan account!");
        }
        public override decimal InterestAmmount(int months)
        {
            decimal ammount = 0;
            months -= 2;
            string customerType = base._customer.typeOfCustomer();
            if (customerType == "individual")
            {
                months--;
            }
            if (months > 0)
            {
                ammount = base._interestRate * months;
            }
            return ammount;
        }
    }
}
