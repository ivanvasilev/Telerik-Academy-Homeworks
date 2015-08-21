// Problem 2. Gravitation on the Moon
// The gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;
using System.Globalization;
using System.Threading;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("This program calculates your weight on the Moon.");
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please write your weight in kg: ");
        double inputWeight = double.Parse(Console.ReadLine());
        double weightOnTheMoon = inputWeight * 0.17;
        Console.WriteLine("Your weight on the Moon would be exactly: {0}kg", weightOnTheMoon);
    }
}

