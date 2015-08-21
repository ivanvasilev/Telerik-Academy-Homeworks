// Problem 1. Say Hello
// Write a method that asks the user for his name and prints “Hello, <name>”
// Write a program to test this method.

using System;

class SayHello
{
    static void Main()
    {
        Console.WriteLine("This program is greeting the user.");
        Console.Write("Please enter your name: ");
        string inputName = Console.ReadLine();
        Console.WriteLine(Greeting(inputName));
    }

    public static string Greeting (string inputName)
    {
        return String.Format("Hello, {0}!", inputName);
    }
} 