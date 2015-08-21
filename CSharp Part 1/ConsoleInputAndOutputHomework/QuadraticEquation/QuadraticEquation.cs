// Problem 6. Quadratic Equation
// Write a program that reads the coefficients a, b and c of a quadratic equation
// ax2 + bx + c = 0 and solves it (prints its real roots).

using System;
using System.Globalization;
using System.Threading;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program finds the roots of a quadratic equation by given coefficients.");
        Console.Write("Please enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());
        double discriminant = (b * b) - 4 * (a * c);
        double x1, x2;
        if (discriminant > 0)
        {
            //There are two real roots of the equation, because the discriminant is positive.
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("The equation has two real roots: x1 = {0:0.00} and x2 = {1:0.00}", x1, x2);
        }
        else if (discriminant == 0)
        {
            //There is only one real root of the equation, because the discriminant is equal to 0.
            x1 = x2 = -b / (2 * a);
            Console.WriteLine("The equation has only one real root: x1 = x2 = {0:0.00}", x1);
        }
        else
        {
            //The discriminant is negative. That means that the equation has no real roots.
            Console.WriteLine("The equation has no real roots.");
        }
    }
}