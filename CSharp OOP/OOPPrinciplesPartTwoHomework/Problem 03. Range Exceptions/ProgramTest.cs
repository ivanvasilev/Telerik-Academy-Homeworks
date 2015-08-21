// Problem 3. Range Exceptions
  // Define a class InvalidRangeException<T> that holds information about an error condition 
  // related to invalid range. It should hold error message and a range definition [start … end].
  // Write a sample application that demonstrates the InvalidRangeException<int> and 
  // InvalidRangeException<DateTime> by entering numbers in the range [1..100] 
  // and dates in the range [1.1.1980 … 31.12.2013].

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class ProgramTest
    {
        static void Main()
        {
            Console.Write("Please enter a number i n the range [1..100]: ");
            int number = int.Parse(Console.ReadLine());
            
            if (number < 1 || number > 100)
            {
                throw new InvalidRangeException<int>("Number must be in range [1..100]", 1, 100);
            }
            Console.WriteLine("Correct number!");

            Console.Write("Please enter a date in the range [1.1.1980 … 31.12.2013] in format dd/MM/yyyy: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            
            var startDate = new DateTime(1980, 1, 1);
            var endDate = new DateTime(2013, 12, 31);
            
            if (date < startDate || date > endDate)
            {
                throw new InvalidRangeException<DateTime>("Date must be in range [1.1.1980] - [31.12.2013]", startDate, endDate);
            }
            Console.WriteLine("Correct date!");
        }
    }
}
