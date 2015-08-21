namespace BankAccounts.Accounts
{
    using BankAccounts.Customers;
    using BankAccounts.Interfaces;
    using System;

    public class DepositAccount : Account, IDeposit, IWithDraw
    {
        // Constructor
        public DepositAccount(Customer customer, decimal balance, decimal interesrRate)
            : base(customer, balance, interesrRate)
        {

        }
        // Methods
        public void WithDrawMoney(decimal ammount)
        {
            if (ammount > this.Balance)
            {
                throw new ArgumentOutOfRangeException("There isn't enough money in the account!");
            }
            this.Balance -= ammount;
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (numberOfMonths < 0)
            {
                throw new ArgumentOutOfRangeException("Number of months can not be a negative number!");
            }
            if (this.Balance < 1000)
            {
                return 0;
            };
            return base.CalculateInterest(numberOfMonths);
        }
    }
}