namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    class MathOperationsTester
    {
        private static readonly Stopwatch StopWatch = new Stopwatch();
        private const int IntegerValue = 1;
        private const long LongValue = 1L;
        private const float FloatValue = 1.0f;
        private const double DoubleValue = 1.0;
        private const decimal DecimalValue = 1.0M;
        private const int OperationCount = 1000000;

        public static void PerformanceTest(Operation operation)
        {
            Console.WriteLine("*****" + operation.ToString().ToUpper() + "*****");

            int resultInt = IntegerValue;
            StopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (operation)
                {
                    case Operation.Add:
                        resultInt += IntegerValue;
                        break;
                    case Operation.Substract:
                        resultInt -= IntegerValue;
                        break;
                    case Operation.Multiply:
                        resultInt *= IntegerValue;
                        break;
                    case Operation.Divide:
                        resultInt /= IntegerValue;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operation!");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-20}:{1}", "Int", StopWatch.Elapsed);
            StopWatch.Reset();

            long resultLong = LongValue;
            StopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (operation)
                {
                    case Operation.Add:
                        resultLong += LongValue;
                        break;
                    case Operation.Substract:
                        resultLong -= LongValue;
                        break;
                    case Operation.Multiply:
                        resultLong *= LongValue;
                        break;
                    case Operation.Divide:
                        resultLong /= LongValue;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operation!");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-20}:{1}", "Long", StopWatch.Elapsed);
            StopWatch.Reset();

            float resultFloat = FloatValue;
            StopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (operation)
                {
                    case Operation.Add:
                        resultFloat += FloatValue;
                        break;
                    case Operation.Substract:
                        resultFloat -= FloatValue;
                        break;
                    case Operation.Multiply:
                        resultFloat *= FloatValue;
                        break;
                    case Operation.Divide:
                        resultFloat /= FloatValue;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operation!");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-20}:{1}", "Float", StopWatch.Elapsed);
            StopWatch.Reset();

            double resultDouble = DoubleValue;
            StopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (operation)
                {
                    case Operation.Add:
                        resultDouble += DoubleValue;
                        break;
                    case Operation.Substract:
                        resultDouble -= DoubleValue;
                        break;
                    case Operation.Multiply:
                        resultDouble *= DoubleValue;
                        break;
                    case Operation.Divide:
                        resultDouble /= DoubleValue;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operation!");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-20}:{1}", "Double", StopWatch.Elapsed);
            StopWatch.Reset();

            decimal resultDecimle = DecimalValue;
            StopWatch.Start();

            for (int i = 0; i < OperationCount; i++)
            {
                switch (operation)
                {
                    case Operation.Add:
                        resultDecimle += DecimalValue;
                        break;
                    case Operation.Substract:
                        resultDecimle -= DecimalValue;
                        break;
                    case Operation.Multiply:
                        resultDecimle *= DecimalValue;
                        break;
                    case Operation.Divide:
                        resultDecimle /= DecimalValue;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operation!");
                }
            }

            StopWatch.Stop();
            Console.WriteLine("{0,-20}:{1}", "Decimal", StopWatch.Elapsed);
            StopWatch.Reset();
        }
    }
}