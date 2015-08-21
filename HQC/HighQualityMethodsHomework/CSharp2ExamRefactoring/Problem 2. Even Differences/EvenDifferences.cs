namespace CSharp2ExamRefactoring
{
    using System;
    using System.Linq;
    using System.Numerics;

    class EvenDifference
    {
        static void Main(string[] args)
        {
            BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            BigInteger absoluteDifference = 0;
            BigInteger sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                absoluteDifference = numbers[i] - numbers[i - 1];
                if (absoluteDifference < 0)
                {
                    absoluteDifference = -absoluteDifference;
                }
                if (absoluteDifference % 2 == 0)
                {
                    i += 1;
                    sum += absoluteDifference;
                }
            }
            Console.WriteLine(sum);
        }
    }
}