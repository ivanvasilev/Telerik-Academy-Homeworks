// Problem 9. Play with Int, Double and String
// Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        // If the variable is int or double, the program increases it by one.
        // If the variable is a string, the program appends * at the end.
// Print the result at the console. Use switch statement.

using System;
using System.Globalization;
using System.Threading;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please enter a digit between 1 and 3, where: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        Console.Write("Input number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        switch (inputNumber)
        {
            case 1: Console.Write("Please enter an integer number: ");
                int intVariable = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + ++intVariable);
                break;
            case 2: Console.Write("Please enter a double: ");
                double doubleVariable = double.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + ++doubleVariable);
                break;
            case 3: Console.Write("Please enter a string: ");
                string stringVariable = Console.ReadLine();
                Console.WriteLine("Result: {0}*", stringVariable);
                break;
            default: Console.WriteLine("Not a valid number.");
                break;
        }

    }
}