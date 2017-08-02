using System;

namespace Problem0003
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            var lpf = CalculatePrimeFactor(600851475143L, 2L);
            stopwatch.Stop();

            Console.WriteLine("Largest Prime Factors: {0} (time: {1}ms)", lpf, stopwatch.Elapsed.TotalMilliseconds);
        }

        public static Int64 CalculatePrimeFactor(Int64 num, Int64 lpf) 
        {
            if(lpf > Math.Sqrt(num)) {
                return num;
            } else if(num%lpf == 0) {
                return CalculatePrimeFactor(num/lpf, 2L);
            } else {
                return CalculatePrimeFactor(num, lpf+1);
            }
        }
    }
}
