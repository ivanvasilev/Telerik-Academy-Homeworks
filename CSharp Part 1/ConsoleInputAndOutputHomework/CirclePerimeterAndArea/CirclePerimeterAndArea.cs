// Problem 3. Circle Perimeter and Area
// Write a program that reads the radius r of a circle and prints its perimeter and area 
// formatted with 2 digits after the decimal point.

using System;
using System.Globalization;
using System.Threading;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program calculates the perimeter and radius of a circle by given radius.");
        Console.Write("Please insert the radius: ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = Math.PI * 2 * r;
        double area = Math.PI * r * r;
        Console.WriteLine("The perimeter of a circle with radius {0} is {1: 0.00}", r, perimeter);
        Console.WriteLine("the area of a circle with radius {0} is {1: 0.00}", r, area);
    }
}