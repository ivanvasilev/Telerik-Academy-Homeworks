// Problem 9. Trapezoids
// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
using System.Globalization;
using System.Threading;

class Trapezoids
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program calculates the area of a trapezoid by given sides and height.");
        Console.Write("Please insert the length first side: ");
        double firstSide = double.Parse(Console.ReadLine());
        Console.Write("Please insert the length of the second side: ");
        double secondSide = double.Parse(Console.ReadLine());
        Console.Write("Please insert the length of the height: ");
        double height = double.Parse(Console.ReadLine());
        double result = (firstSide + secondSide) / 2 * height;
        Console.WriteLine("The area of the trapezoid is: " + result);
    }
}
