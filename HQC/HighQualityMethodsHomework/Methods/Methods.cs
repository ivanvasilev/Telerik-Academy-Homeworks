namespace Methods
{
    using System;

    class Methods
    {
        internal static double CalculateTriangleArea(double a, double b, double c)
        {
            bool areAllSidesPositive = a > 0 || b > 0 || c > 0;
            bool areAllSidesValid = (a + b > c) && (a + c > b) && (b + c > a);
            string errorMessageForNegativeSides = "All sides should be positive!";
            string errorMessageForInvalidSideLengths = "The sum of every two sides of the triangle must be greater than the third side!";

            if (!areAllSidesPositive)
            {
                throw new ArgumentOutOfRangeException(errorMessageForNegativeSides);
            }

            if (!areAllSidesValid)
            {
                throw new ArgumentException(errorMessageForInvalidSideLengths);
            }
            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            return area;
        }

        internal static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            return number + "is not a digit!";
        }

        internal static int FindMax(params int[] elements)
        {
            string errorMessageForEmptyArray = "The array must not be null or empty!";

            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException(errorMessageForEmptyArray);
            }

            int maxNumber = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxNumber)
                {
                    maxNumber = elements[i];
                }
            }
            return maxNumber;
        }

        internal static void NumberWithPrecision(double number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        internal static void NumberAsPercentage(double number)
        {
            {
                Console.WriteLine("{0:p0}", number);
            }
        }

        internal static void NumberRightAligned(double number)
        {
            Console.WriteLine("{0,8}", number);
        }


        internal static double CalculateDistance(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double distance = Math.Sqrt((secondPointX - firstPointX) * (secondPointX - firstPointX) +
                                        (secondPointY - firstPointY) * (secondPointY - firstPointY));
            return distance;
        }

        internal static bool IsLineHorizontal(double firstPointY, double secondPointY)
        {
            const double AcceptableDifference = 0.000001;
            return Math.Abs(firstPointY - secondPointY) < AcceptableDifference;
        }

        internal static bool IsLineVertical(double firstPointX, double secondPointX)
        {
            const double AcceptableDifference = 0.000001;
            return Math.Abs(firstPointX - secondPointX) < AcceptableDifference;
        }
    }
}
