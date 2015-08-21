using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSimpleMaths
{
    class MainProgram
    {
        static void Main()
        {
            MathOperationsTester.PerformanceTest(Operation.Add);
            MathOperationsTester.PerformanceTest(Operation.Substract);
            MathOperationsTester.PerformanceTest(Operation.Multiply);
            MathOperationsTester.PerformanceTest(Operation.Divide);
        }
    }
}
