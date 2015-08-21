// Problem 7. Point in a Circle
// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
using System.Globalization;
using System.Threading;

class PointInACircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program checks if given point with coordinates (x,y) is in the circle K({0, 0}, 2)");
        Console.Write("Please enter the x-coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter the y-coordinate: ");
        double y = double.Parse(Console.ReadLine());
        double radius = 2.0;
        bool result = (x * x) + (y * y) <= radius * radius; 
        Console.WriteLine("Is this point in the circle: " + result);
    }
}