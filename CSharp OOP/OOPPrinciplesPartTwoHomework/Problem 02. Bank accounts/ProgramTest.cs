// Problem 2. Bank accounts
// A bank holds different types of accounts for its customers: deposit accounts, loan accounts 
// and mortgage accounts. Customers could be individuals or companies.
// All accounts have customer, balance and interest rate (monthly based).
// Deposit accounts are allowed to deposit and with draw money.
// Loan and mortgage accounts can only deposit money.
// All accounts can calculate their interest amount for a given period (in months). 
// In the common case its is calculated as follows: number_of_months * interest_rate.
// Loan accounts have no interest for the first 3 months if are held by individuals and for the 
// first 2 months if are held by a company.
// Deposit accounts have no interest if their balance is positive and less than 1000.
// Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the 
// first 6 months for individuals.
// Your task is to write a program to model the bank system by classes and interfaces.
// You should identify the classes, interfaces, base classes and abstract actions and implement 
// the calculation of the interest functionality through overridden methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    using BankAccounts.Accounts;
    using BankAccounts.Customers;
    using BankAccounts.Interfaces;

    class ProgramTest
    {
        static void Main()
        {
            // Making instances of all types of accounts with the two types of customers
            DepositAccount first = new DepositAccount(new IndividualCustomer("Jimmy Hendrix"), 1500, 5);
            DepositAccount second = new DepositAccount(new CompanyCustomer("Jimmy Hendrix"), 500, 5);
            LoanAccount third = new LoanAccount(new IndividualCustomer("Jimmy Hendrix"), 4000, 7);
            LoanAccount fourth = new LoanAccount(new CompanyCustomer("Jimmy Hendrix"), 50000, 3);
            MortgageAccount fifth = new MortgageAccount(new IndividualCustomer("Jimmy Hendrix"), 34000, 4);
            MortgageAccount sixth = new MortgageAccount(new CompanyCustomer("Jimmy Hendrix"), 19000, 9);
            // Testing the DepositMoney, WithDrawMoney and CalculateInterest methods for all account types
            Console.WriteLine("INDIVIDUAL DEPOSIT ACCOUNT:");
            Console.WriteLine("Balance: {0}", first.Balance);
            first.DepositMoney(10);
            Console.WriteLine("Balance after deposit: {0}", first.Balance);
            first.WithDrawMoney(150);
            Console.WriteLine("Balance after withdraw: {0}", first.Balance);
            Console.WriteLine("Calculate interest: {0}", first.CalculateInterest(5));
            Console.WriteLine();
            Console.WriteLine("CUSTOMER DEPOSIT ACCOUNT: ");
            Console.WriteLine("Balance: {0}", second.Balance);
            second.DepositMoney(2000);
            Console.WriteLine("Balance after deposit: {0}", second.Balance);
            second.WithDrawMoney(1800);
            Console.WriteLine("Balance after withdraw: {0}", second.Balance);
            Console.WriteLine("Calculate interest: {0}", second.CalculateInterest(9));
            Console.WriteLine();
            Console.WriteLine("INDIVIDUAL LOAN ACCOUNT:");
            Console.WriteLine("Balance: {0}", third.Balance);
            third.DepositMoney(60);
            Console.WriteLine("Balance after deposit: {0}", third.Balance);
            Console.WriteLine("Calculate interest: {0}", third.CalculateInterest(7));
            Console.WriteLine();
            Console.WriteLine("CUSTOMER LOAN ACCOUNT:");
            Console.WriteLine("Balance: {0}", fourth.Balance);
            fourth.DepositMoney(60);
            Console.WriteLine("Balance after deposit: {0}", fourth.Balance);
            Console.WriteLine("Calculate interest: {0}", fourth.CalculateInterest(9));
            Console.WriteLine();
            Console.WriteLine("INDIVIDUAL MORTGAGE ACCOUNT:");
            Console.WriteLine("Balance: {0}", fifth.Balance);
            fifth.DepositMoney(100);
            Console.WriteLine("Balance after deposit: {0}", fifth.Balance);
            Console.WriteLine("Calculate interest: {0}", fifth.CalculateInterest(6));
            Console.WriteLine();
            Console.WriteLine("CUSTOMER MORTGAGE ACCOUNT:");
            Console.WriteLine("Balance: {0}", sixth.Balance);
            sixth.DepositMoney(100);
            Console.WriteLine("Balance after deposit: {0}", sixth.Balance);
            Console.WriteLine("Calculate interest: {0}", sixth.CalculateInterest(11));
            
            // Testing the Bank class and the AddAccount method
            Bank newBank = new Bank(LoadList());
            Console.WriteLine();
            newBank.AddAccount(new DepositAccount(new IndividualCustomer("Joe Rogan"), 780, 3));
            Console.WriteLine("Type of customer: " + newBank.Accounts[6].Customer.GetType().Name);
            Console.WriteLine("Name: " + newBank.Accounts[6].Customer.Name);
            Console.WriteLine("Balance: " + newBank.Accounts[6].Balance);
            Console.WriteLine("Interest rate: " + newBank.Accounts[6].InterestRate);
        }

        static List<Account> LoadList()
        {
            List<Account> load = new List<Account>();
            load.Add(new DepositAccount(new IndividualCustomer("Jimmy Hendrix"), 500, 5));
            load.Add(new DepositAccount(new CompanyCustomer("Jimmy Hendrix"), 500, 5));
            load.Add(new LoanAccount(new IndividualCustomer("Jimmy Hendrix"), 500, 5));
            load.Add(new LoanAccount(new CompanyCustomer("Jimmy Hendrix"), 500, 5));
            load.Add(new MortgageAccount(new IndividualCustomer("Jimmy Hendrix"), 500, 5));
            load.Add(new MortgageAccount(new CompanyCustomer("Jimmy Hendrix"), 500, 5));
            return load;
        }
    }
}
