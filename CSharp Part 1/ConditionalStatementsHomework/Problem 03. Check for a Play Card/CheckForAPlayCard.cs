// Problem 3. Check for a Play Card
// Classical play cards use the following signs to designate the card face: 
// 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
// Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.

using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.WriteLine("This program checks if a given inputted symbol is a valid card sign.");
        Console.Write("Please enter a card sign: ");
        string inputSymbol = Console.ReadLine();
        string resultText = "Is this a valid card sign: ";

        switch (inputSymbol)
        {
            case "2": Console.WriteLine(resultText + "yes"); 
                break;
            case "3": Console.WriteLine(resultText + "yes"); 
                break;
            case "4": Console.WriteLine(resultText + "yes"); 
                break;
            case "5": Console.WriteLine(resultText + "yes"); 
                break;
            case "6": Console.WriteLine(resultText + "yes"); 
                break;
            case "7": Console.WriteLine(resultText + "yes"); 
                break;
            case "8": Console.WriteLine(resultText + "yes"); 
                break;
            case "9": Console.WriteLine(resultText + "yes"); 
                break;
            case "10": Console.WriteLine(resultText + "yes"); 
                break;
            case "J": Console.WriteLine(resultText + "yes"); 
                break;
            case "Q": Console.WriteLine(resultText + "yes"); 
                break;
            case "K": Console.WriteLine(resultText + "yes"); 
                break;
            case "A": Console.WriteLine(resultText + "yes"); 
                break;
            default: Console.WriteLine(resultText + "no");
                break;
        }
    }
}