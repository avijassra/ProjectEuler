namespace CSharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            var fibSeries = new List<int>();
            GenerateFibonacciSeries(0, 1, ref fibSeries);
            var sum = fibSeries.Where(x => x%2 == 0).Sum();
            stopwatch.Stop();
            Console.WriteLine("Total: {0} (time: {1}ms)", sum, stopwatch.Elapsed.TotalMilliseconds);
        }

        private static void GenerateFibonacciSeries(int a, int b, ref List<int> list) 
        {
            var sum = a+b;
            if(sum < 4000000) {
                list.Add(sum);
                GenerateFibonacciSeries(b, sum, ref list);
            }
        }
    }
}
