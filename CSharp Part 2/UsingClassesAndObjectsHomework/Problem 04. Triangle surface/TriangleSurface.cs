// Problem 4. Triangle surface
// Write methods that calculate the surface of a triangle by given:
    // Side and an altitude to it;
    // Three sides;
    // Two sides and an angle between them;
// Use System.Math.

using System;
using System.Globalization;
using System.Threading;

class TriangleSurface
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("This program calculates the surface of a triangle by given:" +
                          "\n1.Side and an altitude to it\n2.Three sides\n" +
                          "3.Two sides and an angle between them");
        Console.Write("Enter with which method you want the program to calculate the surface: ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 1:
                SurfaceByGivenSideAndAltitude();
                break;
            case 2: 
                SurfaceByGivenThreeSides();
                break;
            case 3:
                SurfaceByGivenTwoSidesAndAngleBetweenThem();
                break;
            default: Console.WriteLine("Invalid input!\nThe input number must be 1, 2 or 3.");
                break;
        }
    }

    static void SurfaceByGivenSideAndAltitude()
    {
        Console.Write("Please enter the size of the side: ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Please enter the size of the altitude of the side: ");
        double altitude = double.Parse(Console.ReadLine());
        double surface = (double)(side * altitude / 2);
        Console.WriteLine("The surface of a triangle with side = {0} and altitude to it = {1} is: {2:F2}"
                          , side, altitude, surface);
    }
    
    static void SurfaceByGivenThreeSides()
    {
        Console.Write("Please enter the size of the first side: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the size of the second side: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the size of the third side: ");
        double c = double.Parse(Console.ReadLine());
        if (a + b <= c || a + c < b || b + c < a)
        {
            Console.WriteLine("Invalid side values!\nThe sum of every two sides of the triangle " +
                              "must be greater than the third side, else the triangle won't exist.");
            return;
        }
        double p = (a + b + c) / 2;
        double surface = (double)(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        Console.WriteLine("The surface of a triangle with sides a = {0}, b = {1} and c = {2} is: {3:F2}"
                          , a, b, c, surface);
    }

    static void SurfaceByGivenTwoSidesAndAngleBetweenThem()
    {
        Console.Write("Please enter the size of the first side: ");
        double firstSide = double.Parse(Console.ReadLine());
        Console.Write("Please enter the size of the second side: ");
        double secondSide = double.Parse(Console.ReadLine());
        Console.Write("Please enter the size of the angle between the sides: ");
        double angle = double.Parse(Console.ReadLine());
        double angleValue = Math.Sin(Math.PI * angle / 180);
        if (angle <= 0 || angle >= 180)
        {
            Console.WriteLine("Invalid angle size!\nThe size of the angle must be in the range (0, 180).");
            return;
        }
        double surface = (double)(firstSide * secondSide * angleValue) / 2;
        Console.WriteLine("The surface of a triangle with sides a = {0}, b = {1} and " +
            "angle between them = {2} is: {3:F2}", firstSide, secondSide, angle, surface);
    }
}