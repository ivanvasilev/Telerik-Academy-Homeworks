// Problem 2. Print Company Information
// A company has name, address, phone number, fax number, web site and manager. 
// The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("This program prints company information.");
        Console.WriteLine();
        string companyName = "Company: Fantastico";
        string companyAddress = "Address: 14A Momina salza, Sofia";
        string phoneNumber = "Tel. +359 2 969 25 00";
        string faxNumber = "Fax: (no fax)";
        string webSite = "Web site: http://ff-bg.net/";
        string managerFirstName = "Ivan";
        string managerLastName = "Ivanov";
        byte managerAge = 33;
        string managerPhone = "Tel. +359 888 080 080";
        Console.WriteLine(companyName);
        Console.WriteLine(companyAddress);
        Console.WriteLine(phoneNumber);
        Console.WriteLine(faxNumber);
        Console.WriteLine(webSite);
        Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + " " + "(Age: {0}, {1})", managerAge, managerPhone);
    }
}
