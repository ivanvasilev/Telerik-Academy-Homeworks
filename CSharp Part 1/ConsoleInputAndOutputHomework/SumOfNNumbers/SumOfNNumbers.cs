// Problem 9. Sum of n Numbers
// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

using System;
using System.Globalization;
using System.Threading;

class SumOfNNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter how many numbers you want the program to calculate: ");
        int count = int.Parse(Console.ReadLine());
        if (count < 1)
        {
            Console.WriteLine("No numbers to add.\nPlease start the program again and enter another number.");
        }
        else
        {
            Console.WriteLine("Enter {0} numbers: ", count);
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The sum the numbers is {0:F2}", sum);
        }
    }
}
