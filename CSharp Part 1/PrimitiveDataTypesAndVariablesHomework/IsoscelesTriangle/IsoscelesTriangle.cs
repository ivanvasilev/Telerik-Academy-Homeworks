using System;

class IsoscelesTriangle
{
    static void Main()
    {
        // I made two different ways for solving the problem.
        Console.WriteLine("   ©");
        Console.WriteLine("  © ©");
        Console.WriteLine(" ©   ©");
        Console.WriteLine("© © © ©");
      
        //Console.OutputEncoding = Encoding.UTF8; (you must type this row also, if you don't see the copyright symbols in the console)
        char copyrightSymbol = '\u00A9';
        Console.WriteLine("   " + copyrightSymbol);
        Console.WriteLine("  " + copyrightSymbol + " " + copyrightSymbol);
        Console.WriteLine(" " + copyrightSymbol + "   " + copyrightSymbol);
        Console.WriteLine(copyrightSymbol + " " + copyrightSymbol + " " + copyrightSymbol + " " + copyrightSymbol);
    }
}