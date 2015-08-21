namespace Methods
{
    using System;

    internal class MainProgram
    {
        private static void Main()
        {
            Console.WriteLine(Methods.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.NumberToDigit(5));

            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Methods.NumberWithPrecision(1.3);
            Methods.NumberAsPercentage(0.75);
            Methods.NumberRightAligned(2.30);

            bool isHorizontal = Methods.IsLineHorizontal(-1, 2.5);
            bool isVertical = Methods.IsLineVertical(3, 3);
            double distance = Methods.CalculateDistance(3, -1, 3, 2.5);
            Console.WriteLine(distance);
            Console.WriteLine("Horizontal? : " + isHorizontal);
            Console.WriteLine("Vertical? : " + isVertical);

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "From Sofia");

            Student stella = new Student("Stella", "Markova", new DateTime(1993, 11, 3), "From Vidin, gamer, high results");

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
