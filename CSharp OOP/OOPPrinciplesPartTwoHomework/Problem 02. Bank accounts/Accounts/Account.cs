namespace BankAccounts.Accounts
{
    using BankAccounts.Customers;
    using BankAccounts.Interfaces;
    using System;

    public abstract class Account : IDeposit
    {
        // Fields
        private Customer customer;
        protected decimal balance;
        private decimal interestRate;
        // Constructor
        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        // Properties
        public Customer Customer { get; private set; }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance can not be a negative number!");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate 
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance can not be a negative number!");
                }
                this.interestRate = value;
            }
        }
        // Methods
        public void DepositMoney(decimal ammount)
        {
            this.Balance += ammount;
        }

        public virtual decimal CalculateInterest(int numberOfMonths)
        {
            decimal result = (this.InterestRate / 100m) * numberOfMonths;
            return result * this.Balance;
        }
    }
}
