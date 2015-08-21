namespace BankAccounts.Customers
{
    using System;

    public abstract class Customer
    {
        // Field
        private string name;
        // Constructor
        public Customer(string name)
        {
            this.Name = name;
        }
        // Property
        public string Name 
        { 
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Customer name can not be empty!");
                }
                this.name = value;
            }
        }
    }
}
