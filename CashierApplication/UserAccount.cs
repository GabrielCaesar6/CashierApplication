using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal class UserAccount
    {
        private string full_name;
        private string user_name;
        private string user_password;

        public UserAccount(string name, string uName, string password)
        {
            full_name = name;
            user_name = uName;
            user_password = password;
        }

        public bool validateLogin(string uName, string password)
        {
            return user_name == uName && user_password == password;
        }

        public string getFullName()
        {
            return full_name;
        }

    }
}
