// In the first CSharp Exam I managed to solve only problems 1, 2 and 4.

namespace CSharpPartOneExam
{
    using System;

    class Printing
    {
        static void Main()
        {
            const int numberOfSheetsInOneRealm = 500;

            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfPaperSheets = int.Parse(Console.ReadLine());
            decimal priceOfOneRealm = decimal.Parse(Console.ReadLine());

            int totalAmountOfSheets = numberOfStudents * numberOfPaperSheets;
            decimal totalAmountOfRealms = (decimal)totalAmountOfSheets / numberOfSheetsInOneRealm;

            decimal totalAmountOfMoney = totalAmountOfRealms * priceOfOneRealm;

            Console.WriteLine("{0:F2}", totalAmountOfMoney);
        }
    }
}
