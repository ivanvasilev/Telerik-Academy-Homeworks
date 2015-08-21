//Problem 6. Divisible by 7 and 3
//    Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//    Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace DivisibleBySevenAndThree
{
    using System;
    using System.Linq;

    class ProgramTest
    {
        public static void NumbersDivisibleBy7And3UsingLambdaExpressions(int[] input)
        {
            var result = input.Where(n => n % 3 == 0 && n % 7 == 0).OrderBy(n => n).ToArray();
            Console.Write("Print numbers in array, divisible both by 7 and 3, using lambda expressions are: ");
            Print(result);
        }

        public static void NumbersDivisibleBy7And3UsingLinqQueries(int[] input)
        {
            var result =
                from n in input
                where n % 3 == 0 && n % 7 == 0
                orderby n
                select n;
            Console.Write("Print numbers in array, divisible both by 7 and 3, using Linq queries are: ");
            Print(result.ToArray());
        }

        private static void Print(int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                if (i != result.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        static void Main()
        {
            int[] test = new int[] {3, 76, 656, 32, 14, 21, 37, 63, 45, 231, 21};
            NumbersDivisibleBy7And3UsingLambdaExpressions(test);
            NumbersDivisibleBy7And3UsingLinqQueries(test);
        }
    }
}