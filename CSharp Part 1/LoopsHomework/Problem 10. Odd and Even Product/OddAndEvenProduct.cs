// Problem 10. Odd and Even Product
// You are given n integers (given in a single line, separated by a space).
// Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
// Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Please enter as many as You like positive integer number in a single line, separated by space: ");
        string inputNumbers = Console.ReadLine();
        string[] numbers = inputNumbers.Split(new char[] { '\u0020' }, StringSplitOptions.RemoveEmptyEntries);
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = int.Parse(numbers[i]);
            if (i % 2 == 0)
            {
                evenProduct *= currentNumber;
            }
            else if (i % 2 != 0)
            {
                oddProduct *= currentNumber;
            }
        }
        bool equalProducts = oddProduct == evenProduct;
        Console.WriteLine(equalProducts ? "Yes\nProduct = {0}" : "No\nOddProduct = {0}\nEvenProduct = {1}"
        , oddProduct, evenProduct);
    }
}