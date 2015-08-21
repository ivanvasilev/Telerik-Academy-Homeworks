// Problem 2. Bonus Score
// Write a program that applies bonus score to given score in the range [1…9] by the following rules:
    // If the score is between 1 and 3, the program multiplies it by 10.
    // If the score is between 4 and 6, the program multiplies it by 100.
    // If the score is between 7 and 9, the program multiplies it by 1000.
    // If the score is 0 or more than 9, the program prints “invalid score”.

using System;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("This program applies bonus score in the range [1..9].");
        Console.Write("Please add an integer number between 1 and 9: ");
        int inputNumber = int.Parse(Console.ReadLine());
        string textResult = "Your bonus score is: ";
        int firstResult = inputNumber * 10;
        int secondResult = inputNumber * 100;
        int thirdResult = inputNumber * 1000;

        if (inputNumber == 1 || inputNumber == 2 || inputNumber == 3)
        {
            Console.WriteLine(textResult + firstResult);
        }
        else if (inputNumber == 4 || inputNumber == 5 || inputNumber == 6)
        {
            Console.WriteLine(textResult + secondResult);
        }
        else if (inputNumber == 7 || inputNumber == 8 || inputNumber == 9)
        {
            Console.WriteLine(textResult + thirdResult);
        }
        else
        {
            Console.WriteLine("Invalid score");
        }
    }
}