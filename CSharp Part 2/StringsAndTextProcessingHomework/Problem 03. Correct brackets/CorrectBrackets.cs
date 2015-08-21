// Problem 3. Correct brackets
// Write a program to check if in a given expression the brackets are put correctly.

using System;

class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("This program checks if in given expression the brackets are put correctly.");
        Console.Write("Please enter an expression with brackets: ");
        string expression = Console.ReadLine();
        int counterForOpenBrackets = 0;
        int counterForCloseBrackets = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                counterForOpenBrackets++;
            }
            if (expression[i] == ')')
            {
                counterForCloseBrackets++;
            }
            if (counterForCloseBrackets > counterForOpenBrackets)
            {
                Console.WriteLine("Incorrect!");
                return;
            }
        }
        if (counterForOpenBrackets == counterForCloseBrackets)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }
    }
}