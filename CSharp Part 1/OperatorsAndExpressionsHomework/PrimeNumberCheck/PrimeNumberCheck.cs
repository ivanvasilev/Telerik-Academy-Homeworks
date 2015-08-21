// Problem 8. Prime Number Check
// Write an expression that checks if given positive integer number n (n <= 100) is prime 
// (i.e. it is divisible without remainder only to itself and 1).
// Note: You should check if the number is positive

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("this program checks if given positive integer between 1 and 100 is prime.");
        Console.Write("Please enter an integer between 1 and 100: ");
        int inputNumber = int.Parse(Console.ReadLine());
        bool isPrime;
        if (inputNumber <= 0 || inputNumber > 100)
        {
            isPrime = false;
            Console.WriteLine("Invalid value!\nPlease try again.");
        }
        else if (inputNumber == 1)
        {
            isPrime = false;
            Console.WriteLine("The number is prime: {0}", isPrime);
        }
        else
        {
            for (int i = 2; i < inputNumber; i++)
            {
                if (inputNumber % i == 0)
                {
                    isPrime = false;
                    Console.WriteLine("The number is prime: {0}", isPrime);
                    return;
                }
            }
            isPrime = true;
            Console.WriteLine("The number is prime: {0}", isPrime);
        }
    }
}