namespace CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = Stopwatch.StartNew();
            stopWatch.Start();

            var sum = 0;

            for(var i = 1; i < 1000; i++) {
                if(i%3 == 0 || i%5 == 0) {
                    sum += i;
                }   
            }
            stopWatch.Stop();

            Console.WriteLine("Total {0} (time: {1}ms)", sum, stopWatch.Elapsed.TotalMilliseconds);
            
        }
    }
}
