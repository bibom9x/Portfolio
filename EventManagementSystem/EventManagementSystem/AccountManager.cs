using System.Collections.Generic;

namespace EventManagementSystem
{
    public class AccountManager
    {
        public Dictionary<string, Account> Accounts { get; private set; }

        public AccountManager()
        {
            Accounts = new Dictionary<string, Account>();
        }

        public void RegisterAccount(string username, string password, bool isAdmin)
        {
            if (!Accounts.ContainsKey(username))
            {
                var account = new Account(username, password, isAdmin);
                Accounts.Add(username, account);
            }
        }

        public Account Login(string username, string password)
        {
            if (Accounts.ContainsKey(username) && Accounts[username].Password == password)
            {
                return Accounts[username];
            }
            return null;
        }

        public Account GetAccount(string username)
        {
            return Accounts.ContainsKey(username) ? Accounts[username] : null;
        }
    }
}
