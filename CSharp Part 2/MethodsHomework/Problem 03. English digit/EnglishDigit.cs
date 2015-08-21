// Problem 3. English digit
// Write a method that returns the last digit of given integer as an English word.

using System;

class EnglishDigit
{
    static void Main()
    {
        Console.WriteLine("This program returns the last digit of given integer as an English word.");
        Console.Write("Please enter an integer: ");
        int inputNumber = int.Parse(Console.ReadLine());

        PrintLastDigit(inputNumber);
    }

    static void PrintLastDigit(int number)
    {
        int lastDigit = number % 10;
        switch (lastDigit)
        {
            case 0: Console.WriteLine("The last digit of your number is zero.");
                break;
            case 1: Console.WriteLine("The last digit of your number is one.");
                break;
            case 2: Console.WriteLine("The last digit of your number is two.");
                break;
            case 3: Console.WriteLine("The last digit of your number is three.");
                break;
            case 4: Console.WriteLine("The last digit of your number is four.");
                break;
            case 5: Console.WriteLine("The last digit of your number is five.");
                break;
            case 6: Console.WriteLine("The last digit of your number is six.");
                break;
            case 7: Console.WriteLine("The last digit of your number is seven.");
                break;
            case 8: Console.WriteLine("The last digit of your number is eight.");
                break;
            case 9: Console.WriteLine("The last digit of your number is nine.");
                break;
        }
    }
}