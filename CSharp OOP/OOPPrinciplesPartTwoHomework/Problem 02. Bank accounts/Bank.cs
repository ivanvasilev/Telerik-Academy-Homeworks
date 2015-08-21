using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    using BankAccounts.Interfaces;
    using BankAccounts.Customers;
    using BankAccounts.Accounts;

    public class Bank
    {
        // Field
        private List<Account> accounts;
        // Constructors
        public Bank()
        {
            this.Accounts = new List<Account>();
        }

        public Bank(List<Account> accounts)
        {
            this.Accounts = accounts;
        }
        // Property
        public List<Account> Accounts 
        { 
            get
            {
                return new List<Account>(this.accounts);
            }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("There aren't any accounts!");
                }
                this.accounts = value;
            }
        }
        // Method
        public void AddAccount(Account account)
        {
            this.accounts.Add(account);
        }
    }
}
