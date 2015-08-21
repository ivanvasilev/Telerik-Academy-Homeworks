// Problem 2. Get largest number
// Write a method GetMax() with two parameters that returns the larger of two integers.
// Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.WriteLine("This program reads three numbers and returns the largest among them.");
        Console.Write("Please enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (thirdNumber > firstNumber)
        {
            firstNumber = thirdNumber;
        }

        GetMax(firstNumber, secondNumber);
    }

    static void GetMax (int first, int second)
    {
        if (first > second)
        {
            Console.WriteLine("The largest of the three numbers is: " + first);
        }
        else
        {
            Console.WriteLine("The largest of the three numbers is: " + second);
        }
    }
}