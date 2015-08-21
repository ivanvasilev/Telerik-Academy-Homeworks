//Problem 20.* Infinite convergent series
//    By using delegates develop an universal static method to calculate the sum of infinite 
//    convergent series with given precision depending on a function of its term. By using proper functions 
//    for the term calculate with a 2-digit precision the sum of the infinite series:
//        Example 1: 1 + 1/2 + 1/4 + 1/8 + 1/16 + …
//        Example 2: 1 + 1/2! + 1/3! + 1/4! + 1/5! + …
//        Example 3: 1 + 1/2 - 1/4 + 1/8 - 1/16 + …

namespace InfiniteConvergentSeries
{
    using System;
    using System.Linq;

    class InfiniteConvergentSeries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Result: ");
            Console.WriteLine("1 + 1/2 + 1/4 + 1/8 + 1/16 + ... = {0:F5}", Sum(m => 1 / (decimal)Math.Pow(2, m - 1))); //Example 1
            Console.WriteLine("1 + 1/2! + 1/3! + 1/4! + 1/5! + ... = {0:F5}", Sum(m => 1m / Enumerable.Range(1, m).Aggregate((a, b) => a * b))); //Example 2
            Console.WriteLine("1 + 1/2 - 1/4 + 1/8 - 1/16 + ... = {0:F5}", Sum(m => -1 / (decimal)Math.Pow(-2, m - 1))); //Example 3
        }

        private static decimal Sum(Func<int, decimal> function)
        {
            decimal sum = 1;
            for (int i = 2; Math.Abs(function(i)) > 0.001m; i++)
            {
                sum += function(i);
            }
            return sum;
        }
    }
}
