using System;
using System.Collections.Generic;

namespace Problem0014
{
    class Program
    {
        static void Main(string[] args)
        {
            Solve();
        }

        public static void Solve()
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            var largest = new Tuple<long, long>(0L, 0L);

            for(var ind = 0L; ind < 1000000L; ind++) {
                var cLen = SeriesLen(ind);

                if(cLen > largest.Item2) {
                    largest = new Tuple<long, long>(ind, cLen);
                }
            }

            stopwatch.Stop();

            Console.WriteLine($"Largest Collatz chain is of {largest.Item2} for mnumber starting with: {largest.Item1} (time: {stopwatch.Elapsed.TotalMilliseconds}ms)");
        }

        static int SeriesLen(long num) {
            var clen = new List<long>();
            
            clen.Add(num);

            while (num > 1) {
                num = collatzNumGenerator(num);
                clen.Add(num);
            };

            return clen.Count;
        }

        static long collatzNumGenerator(long num) 
        {
            if(num%2L == 0) 
            {
                return (num/2L);
            }
            else
            {
                return ((3L*num)+1);
            }
        }
    }
}
