// Problem 5. 64 Bit array
    // Define a class BitArray64 to hold 64 bit values inside an ulong value.
    // Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray64
{
    class ProgramTest
    {
        static void Main()
        {
            // Testing the BitArray class and the ToString() method
            Console.WriteLine("Testing the BitArray class and the ToString() method:");
            Console.WriteLine(new string('-', 53));
            BitArray firstArray = new BitArray(127u);
            Console.WriteLine("Number {0} as a 64 bit array: {1}", firstArray.Number, firstArray);
            BitArray secondArray = new BitArray(255u);
            Console.WriteLine("Number {0} as a 64 bit array: {1}",secondArray.Number, secondArray);
            Console.WriteLine();
            var temp = new BitArray(255u);
            // Testing the indexer
            Console.WriteLine("Testing the indexer:");
            Console.WriteLine(new string('-', 20));
            secondArray[5] = 0;
            Console.WriteLine("Number {0} transformed to {1} after changing the bit at position 5.", temp.Number, secondArray.Number);
            Console.WriteLine("Number {0} as a 64 bit array: {1}", secondArray.Number, secondArray);
            Console.WriteLine();
            // Testing the == and != operators 
            Console.WriteLine("Testing the == and != operators:");
            Console.WriteLine(new string('-', 32));
            Console.WriteLine("First array == second array: {0}", firstArray == secondArray);
            Console.WriteLine("First array != second array: {0}", firstArray != secondArray);
            Console.WriteLine();
            // Testing the Equals() and CompareTo() methods
            Console.WriteLine("Testing the Equals() and the CompareTo() methods:");
            Console.WriteLine(new string('-', 49));
            Console.WriteLine("Result of the Equals() method for the first array and the second array: {0}", firstArray.Equals(secondArray));
            Console.WriteLine("Result of the CompareTo() method for the first array and the second array: {0}", firstArray.CompareTo(secondArray));
        }
    }
}
