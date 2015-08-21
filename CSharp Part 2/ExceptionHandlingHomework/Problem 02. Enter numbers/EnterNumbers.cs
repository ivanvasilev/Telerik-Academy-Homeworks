// Problem 2. Enter numbers
// Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
    // If an invalid number or non-number text is entered, the method should throw an exception.
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class EnterNumbers
{
    static int min = 1;
    const int max = 100;
    const int countOfInputNumbers = 10;

    static void Main()
    {
        try
        {
            Console.WriteLine("This program reads ten positive integer numbers in the range (1, 100)," +
                              " and checks if every following number is bigger than the previous.");
            for (int i = 0; i < countOfInputNumbers; i++)
            {
                min = ReadInteger();
            }
            Console.WriteLine("All numbers were correct!");
        }
        catch (FormatException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentOutOfRangeException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    private static int ReadInteger()
    {
        Console.Write("Please enter number in range ({0},{1}): ", min, max);
        int number = int.Parse(Console.ReadLine());
        if (number <= min || number >= max)
        {
            throw new ArgumentOutOfRangeException();
        }
        return number;
    }
}