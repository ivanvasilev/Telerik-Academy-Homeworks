namespace Statistics
{
    using System;

    public class StatisticsPrinter
    {
        public void PrintStatistics(double[] numbers)
        {
            Console.WriteLine("Statistics for {0}", numbers);
            double greatestNumber = GetMax(numbers);
            this.PrintMax(greatestNumber);
            double smallestNumber = GetMin(numbers);
            this.PrintMax(smallestNumber);
            double averageNumber = GetAverage(numbers);
            this.PrintAverage(averageNumber);
        }

        private void PrintMax(double greatestNumber)
        {
            Console.WriteLine("The greatest number is {0}", greatestNumber);
        }

        private void PrintMin(double smallestNumber)
        {
            Console.WriteLine("The smallest number is {0}", smallestNumber);
        }

        private void PrintAverage(double averageNumber)
        {
            Console.WriteLine("The average of all numbers is {0}", averageNumber);
        }

        private double GetMax(double[] numbers)
        {
            double maxNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            return maxNumber;
        }

        private double GetMin(double[] numbers)
        {
            double minNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            return minNumber;
        }

        private double GetAverage(double[] numbers)
        {
            double averageNumber;
            double sum = 0;
            int count = numbers.Length;

            for (int i = 0; i < count; i++)
            {
                sum += numbers[i]; 
            }

            averageNumber = sum / count;

            return averageNumber;
        }
    }
}
