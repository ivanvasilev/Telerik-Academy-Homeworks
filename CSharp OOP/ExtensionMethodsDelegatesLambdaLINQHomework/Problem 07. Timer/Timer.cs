//Problem 7. Timer
//    Using delegates write a class Timer that can execute certain method at each t seconds.

namespace Timer
{
    using System;
    using System.Threading;

    public delegate void RepeatDelegate(int param);
    
    class Timer
    {
        static void Main()
        {
            RepeatDelegate t = delegate(int time)
            {
                Console.WriteLine("Result: ");
                while (true)
                {
                    Thread.Sleep(time);
                    Console.WriteLine("{0:T}", DateTime.Now);
                }
            };
            t(1000);
        }
    }
}
