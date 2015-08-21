namespace Refactoring
{
    using System;

    public class LoopRefactor
    {
        public void PrintValue(int[] numbers, int expectedValue)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 10 == 0 && numbers[i] == expectedValue)
                {
                    Console.WriteLine("Found!");
                    break;
                }

                Console.WriteLine(numbers[i]);
            }
        }
    }
}