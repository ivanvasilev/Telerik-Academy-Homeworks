namespace BankAccounts.Accounts
{
    using BankAccounts.Customers;
    using BankAccounts.Interfaces;
    using System;

    public class MortgageAccount : Account, IDeposit
    {
        
        public MortgageAccount(Customer customer, decimal balance, decimal interesrRate)
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
            else if (numberOfMonths >= 0 && numberOfMonths <= 6)
            {
                numberOfMonths = 0;
            }
            else if (numberOfMonths >= 7 && numberOfMonths <= 12)
            {
                if (this.Customer is IndividualCustomer)
                {
                    numberOfMonths = numberOfMonths - 6;
                }
                if (this.Customer is CompanyCustomer)
                {
                    return ((this.InterestRate / 100m) * numberOfMonths / 2) * this.Balance;
                }
            }
            else
            {
                if (this.Customer is IndividualCustomer)
                {
                    numberOfMonths = numberOfMonths - 6;
                }
                if (this.Customer is CompanyCustomer)
                {
                    numberOfMonths = (numberOfMonths - 12) + 6;
                }
            }
            return base.CalculateInterest(numberOfMonths);
        }
    }
}
