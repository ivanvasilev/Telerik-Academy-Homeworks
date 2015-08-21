// Problem 10. Fibonacci Numbers
// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
// (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Please enter how many numbers of the Fibonacci sequence you want the program to print, " + 
            "starting from the first: ");
        int firstNumber = 0;
        int secondNumber = 1;
        int inputnumber = int.Parse(Console.ReadLine());

        if (inputnumber <= 0)
        {
            Console.WriteLine("Invalid number\nPlease start the program againg and enter a new number");
        }
        else if (inputnumber == 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.Write("0, 1");
            for (int i = 2; i < inputnumber; i++)
            {
                int thirdNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                Console.Write(", " + thirdNumber);
            }
            Console.WriteLine();
        }
    }
}