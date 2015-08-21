//Problem 2. IEnumerable extensions
//    Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
//    sum, product, min, max, average.

namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    class ProgramTest
    {
        static void Main()
        {
            IEnumerable<double> test = new double[] { 4.4, 5.1, 4, 3.67, 3.3};
            
            var sum = IEnumerableT.Sum<double>(test);
            Console.WriteLine("Sum       : {0:F2}", sum);
            var product = IEnumerableT.Product<double>(test);
            Console.WriteLine("Product   : {0:F2}", product);
            var min = IEnumerableT.Min<double>(test);
            Console.WriteLine("Min value : {0:F2}", min);
            var max = IEnumerableT.Max<double>(test);
            Console.WriteLine("Max value : {0:F2}", max);
            var average = IEnumerableT.Average<double>(test);
            Console.WriteLine("Average   : {0:F2}", average);
        }
    }
}
