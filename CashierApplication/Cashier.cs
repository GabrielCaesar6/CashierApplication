using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string dept, string uName, string password)
            : base(name, uName, password)
        {
            department = dept;
        }

        public string getDepartment()
        {
            return department;
        }
    }
}
