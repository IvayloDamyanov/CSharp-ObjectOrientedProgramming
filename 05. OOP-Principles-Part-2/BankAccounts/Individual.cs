using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Individual : Customer
    {
        public override string typeOfCustomer()
        {
            string typeOfCustomer = "individual";
            return typeOfCustomer;
        }
    }
}
