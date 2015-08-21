namespace Exceptions
{
    using System;
    using System.Collections.Generic;

    internal class MainProgram
    {
        static void Main()
        {
            var substr = Helpers.HelpMethods.Subsequence("Jimmy Hendrix".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Helpers.HelpMethods.Subsequence(new[] { 8, 4, 1, 7 }, 1, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = Helpers.HelpMethods.Subsequence(new[] { 8, 4, 1, 7 }, 0, 3);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = Helpers.HelpMethods.Subsequence(new[] { 8, 4, 1, 7 }, 3, 1);
            Console.WriteLine(string.Join(" ", emptyarr));

            Console.WriteLine(Helpers.HelpMethods.ExtractEnding("I can't get no sleep", 2));
            Console.WriteLine(Helpers.HelpMethods.ExtractEnding("Island", 4));
            Console.WriteLine(Helpers.HelpMethods.ExtractEnding("Beach", 4));
            Console.WriteLine(Helpers.HelpMethods.ExtractEnding("Sun", 100));

            try
            {
                Helpers.HelpMethods.CheckPrime(17);
                Console.WriteLine("17 is prime.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("17 is not prime.");
                Console.WriteLine("ErrorMessage: {0}", ex.Message);
            }

            try
            {
                Helpers.HelpMethods.CheckPrime(10);
                Console.WriteLine("10 is prime.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("10 is not prime");
                Console.WriteLine("ErrorMessage: {0}", ex.Message);
            }

            var jimmyExams = new List<Exam>
									{
				                        new SimpleMathExam(2),
										new CSharpExam(55),
										new CSharpExam(100),
										new SimpleMathExam(1),
										new CSharpExam(0)
			                        };
            var peter = new Student("Jimmy", "Hendrix", jimmyExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}