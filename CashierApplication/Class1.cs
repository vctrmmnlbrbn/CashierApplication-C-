using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNameSpace
{
    public class UserAccount
    {
        private string fullname;
        protected string user_name;
        protected string password;

        public UserAccount(string name, string uName, string password)
        {
            fullname = name;
            user_name = uName;
            this.password = password;
        }
        public double validateLogin(string uname, string password)
        {
            if (uname == user_name && password == this.password)
            {
                
                return 1; 
            }
            else
            {
                
                return 0; 
            }
        }
        public string getFullName()
        {
            return fullname;
        }

    }
    public class  Cashier : UserAccount
    {
        private string department;
        public Cashier(string name, string uName, string password, string department) : base(name, uName, password)
        {
            this.department = department;
        }
        public double validateLogin(string uname, string password)
        {
            if (uname == user_name && password == this.password)
            {
                return 1; 
            }
            else
            {
                return 0; 
            }
        }
        public string getDepartment()
        {
            return department;
        }
    }
}
