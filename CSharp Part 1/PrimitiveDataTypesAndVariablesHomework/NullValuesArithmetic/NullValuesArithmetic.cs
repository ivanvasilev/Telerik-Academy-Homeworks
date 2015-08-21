using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? someNumber = null;
        double? anotherNumber = null;

        Console.WriteLine(someNumber);
        Console.WriteLine(anotherNumber);

        Console.WriteLine(someNumber + 1);
        Console.WriteLine(anotherNumber + 2);
    }
}
