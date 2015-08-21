using System;

class ComparingFloats
{
    static void Main()
    {
        // Those values are examples. You can change them.
        double firstValue = 5.00000001;
        double secondValue = 5.00000003;
        bool nearlyEqual = Math.Abs(firstValue - secondValue) < 0.000001;
        Console.WriteLine("The numbers are nearly equal: {0}", nearlyEqual);
    }
}

