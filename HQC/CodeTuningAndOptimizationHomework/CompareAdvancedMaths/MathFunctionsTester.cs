namespace CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;

    public class MathFunctionsTester
    {
        private static readonly Stopwatch StopWatch = new Stopwatch();
        private const float FloatValue = 90.0f;
        private const double DoubleValue = 90.0;
        private const decimal DecimalValue = 90.0M;
        private const int OperationsCount = 100000;

        public static void PerformanceTest(Function function)
        {
            Console.WriteLine("*****" + function.ToString().ToUpper() + "*****");

            float resultFloat = FloatValue;
            StopWatch.Start();

            for (int i = 0; i < OperationsCount; i++)
            {
                switch (function)
                {
                    case Function.Sqrt:
                        resultFloat = (float)Math.Sqrt(FloatValue);
                        break;
                    case Function.Log:
                        resultFloat = (float)Math.Log(FloatValue);
                        break;
                    case Function.Sin:
                        resultFloat = (float)Math.Sin(FloatValue);
                        break;
                    default:
                        throw new InvalidOperationException("Invalid function!");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-15}:{1}", "Float", StopWatch.Elapsed);
            StopWatch.Reset();

            double resultDouble = DoubleValue;
            StopWatch.Start();

            for (int i = 0; i < OperationsCount; i++)
            {
                switch (function)
                {
                    case Function.Sqrt:
                        resultDouble = (double)Math.Sqrt(DoubleValue);
                        break;
                    case Function.Log:
                        resultDouble = (double)Math.Log(DoubleValue);
                        break;
                    case Function.Sin:
                        resultDouble = (double)Math.Sin(DoubleValue);
                        break;
                    default:
                        throw new InvalidOperationException("Invalid function!");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-15}:{1}", "Double", StopWatch.Elapsed);
            StopWatch.Reset();

            decimal resultDecimle = DecimalValue;
            StopWatch.Start();

            for (int i = 0; i < OperationsCount; i++)
            {
                switch (function)
                {
                    case Function.Sqrt:
                        resultDecimle = (decimal)Math.Sqrt((double)DecimalValue);
                        break;
                    case Function.Log:
                        resultDecimle = (decimal)Math.Log((double)DecimalValue);
                        break;
                    case Function.Sin:
                        resultDecimle = (decimal)Math.Sin((double)DecimalValue);
                        break;
                    default:
                        throw new InvalidOperationException("Invalid function!");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-15}:{1}", "Decimal", StopWatch.Elapsed);
            StopWatch.Reset();
        }
    }
}
