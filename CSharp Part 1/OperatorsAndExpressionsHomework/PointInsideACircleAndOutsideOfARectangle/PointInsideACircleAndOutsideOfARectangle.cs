// Problem 10. Point Inside a Circle & Outside of a Rectangle
// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;
using System.Threading;
using System.Globalization;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program checks if given point with coordinates (x,y) is in the circle K({1, 1}, 1.5) and out of a rectangle (top=1, left=-1, width=6, height=2)");
        Console.Write("Please enter the x-coordinate: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please enter the y-coordinate: ");
        double y = Convert.ToDouble(Console.ReadLine());
        double radius = 1.5;
        bool insideCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= radius * radius;
        bool outsideRectangle = (x > -1 && x < 5) && (y > -1 && y < 1);
        if (insideCircle && !outsideRectangle)
        {
            Console.WriteLine("Is the point with coordinates x={0} and y={1} inside the circle and outside the rectangle: Yes", x, y);
        }
        else
        {
            Console.WriteLine("Is the point with coordinates x={0} and y={1} inside the circle and outside the rectangle: No", x, y);
        }
    }
}

