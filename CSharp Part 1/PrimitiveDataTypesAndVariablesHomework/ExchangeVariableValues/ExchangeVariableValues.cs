using System;

class ExchangeVariableValues
{
    static void Main()
    {
        sbyte a = 5;
        sbyte b = 10;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        sbyte c = a;
        a = b;
        b = c;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}

