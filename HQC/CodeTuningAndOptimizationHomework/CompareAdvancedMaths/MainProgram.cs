using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareAdvancedMaths
{
    class MainProgram
    {
        static void Main()
        {
            MathFunctionsTester.PerformanceTest(Function.Sqrt);
            MathFunctionsTester.PerformanceTest(Function.Log);
            MathFunctionsTester.PerformanceTest(Function.Sin);
        }
    }
}
