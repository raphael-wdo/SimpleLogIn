using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class AccountManager
    {
        private List<Account> accounts = new List<Account>();
            
        public AccountManager()
        {
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public Account FindUserAccount(String username)
        {
            Account accountResult = null;
            for (int i = 0; i < accounts.Count() && accountResult == null; i++)
            {
                if (accounts[i].GetUsername().Equals(username))
                {
                    accountResult = accounts[i];
                }
            }

            return accountResult;
        }
    }
}
