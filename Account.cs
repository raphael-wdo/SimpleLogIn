using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Account
    {
        private String username;
        private String password;

        public Account (String username, String password)
        {
            this.username = username;
            this.password = password;
        }

        public String GetUsername()
        {
            return username;
        }

        public bool IsPasswordMatch(String passwordInput)
        {
            bool result = false;
            if (password.Equals(passwordInput))
            {
                result = true;
            }

            return result;
        }
    }
}
