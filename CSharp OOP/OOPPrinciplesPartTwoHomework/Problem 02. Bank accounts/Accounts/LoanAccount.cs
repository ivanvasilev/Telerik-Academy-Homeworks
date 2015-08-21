namespace BankAccounts.Accounts
{
    using BankAccounts.Customers;
    using BankAccounts.Interfaces;
    using System;

    public class LoanAccount : Account, IDeposit
    {
        // Constructor
        public LoanAccount(Customer customer, decimal balance, decimal interesrRate)
            : base(customer, balance, interesrRate)
        {

        }
        // Method
        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (numberOfMonths < 0)
            {
                throw new ArgumentOutOfRangeException("Number of months can not be a negative number!");
            }
            else if (numberOfMonths >= 0 && numberOfMonths <= 2)
            {
                numberOfMonths = 0;
            }
            else if (numberOfMonths == 3)
            {
                if (this.Customer is IndividualCustomer)
                {
                    numberOfMonths = 0;
                }
                if (this.Customer is CompanyCustomer)
                {
                    numberOfMonths -= 2;
                }
            }
            else
            {
                if (this.Customer is IndividualCustomer)
                {
                    numberOfMonths -= 3;
                }
                if (this.Customer is CompanyCustomer)
                {
                    numberOfMonths -= 2;
                }
            }
            return base.CalculateInterest(numberOfMonths);
        }
    }
}
