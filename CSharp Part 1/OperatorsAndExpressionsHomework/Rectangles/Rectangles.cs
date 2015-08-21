// Problem 4. Rectangles
// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;
using System.Globalization;
using System.Threading;

class Rectangles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program calculates the area and perimeter of a rectangle.");
        Console.Write("Please write the width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Please write the length of the rectangle: ");
        double length = double.Parse(Console.ReadLine());
        double area = width * length;
        double perimeter = 2 * (width + length);
        Console.WriteLine("The area of the rectangle is {0}", area);
        Console.WriteLine("The perimeter of the rectangle is {0}", perimeter);
    }
}

