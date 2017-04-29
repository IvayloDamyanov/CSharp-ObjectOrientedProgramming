using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Startup
    {
        static void Main(string[] args)
        {
            #region Customers and Acoounts initialization
            Customer pesho = new Individual();
            Customer banda = new Company();

            Deposit peshoDeposit = new Deposit(pesho, 250, 1.2M); //M for decimal
            Deposit bandaDeposit = new Deposit(banda, 25000, 1.3M); //M for decimal
            Loan peshoLoan = new Loan(pesho, -1500, 6.5M); //M for decimal
            Loan bandaLoan = new Loan(pesho, -15000, 3.5M); //M for decimal
            Mortgage peshoMortgage = new Mortgage(pesho, -48000, 1.2M); //M for decimal
            Mortgage bandaMortgage = new Mortgage(banda, -350000, 1.05M); //M for decimal

            Bank bank = new Bank();
            bank.AddAccount(peshoDeposit);
            bank.AddAccount(bandaDeposit);
            bank.AddAccount(peshoLoan);
            bank.AddAccount(bandaLoan);
            bank.AddAccount(peshoMortgage);
            bank.AddAccount(bandaMortgage);
            #endregion

            #region Calculations test
            //по условие не се изисква да се принтира каквото и да е, теста е само за да се види, че функционалността вади резултат
            Console.WriteLine("Interest amount for given time period (in months):");
            foreach (var account in bank.Accounts)
            {
                Console.WriteLine("{0:0.00}", account.InterestAmmount(15));
                Console.WriteLine("{0:0.00}", account.InterestAmmount(2));
            }
            #endregion
        }
    }
}
