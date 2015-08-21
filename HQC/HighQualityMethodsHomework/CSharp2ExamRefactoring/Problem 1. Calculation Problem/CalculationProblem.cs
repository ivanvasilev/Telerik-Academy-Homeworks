namespace CSharp2ExamRefactoring
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class CalculationProblem
    {
        static void Main(string[] args)
        {
            var alphabet = new List<string> { "a",
                                              "b",
                                              "c",
                                              "d",
                                              "e",
                                              "f",
                                              "g",
                                              "h",
                                              "i",
                                              "j",
                                              "k",
                                              "l",
                                              "m",
                                              "n",
                                              "o",
                                              "p",
                                              "q",
                                              "r",
                                              "s",
                                              "t",
                                              "u",
                                              "v",
                                              "w",};

            string[] input = Console.ReadLine().Split(' ');

            int decimalRepresentation = 0;
            long finalDecimalSum = 0;

            foreach (var word in input)
            {
                string digitIn23 = string.Empty;
                int decimalValue = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    digitIn23 = word.Substring(i, 1);
                    decimalValue = alphabet.IndexOf(digitIn23);
                    decimalRepresentation *= 23;
                    decimalRepresentation += decimalValue;
                }
                finalDecimalSum += decimalRepresentation;
                decimalRepresentation = 0;
            }

            int numeralSystem = 23;
            StringBuilder finalSumIn23thNumeralSystem = new StringBuilder();
            long currentSum = finalDecimalSum;

            while (currentSum > 0)
            {
                int digitIn23th = (int)(currentSum % numeralSystem);
                finalSumIn23thNumeralSystem.Insert(0, alphabet[digitIn23th]);
                currentSum /= numeralSystem;
            }

            Console.WriteLine("{0} = {1}", finalSumIn23thNumeralSystem, finalDecimalSum);
        }
    }
}