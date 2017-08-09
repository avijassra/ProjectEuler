namespace Problem0015
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            var gridLimit = 3;

            var roteOptions = new List<List<Tuple<int, int>>>();
            var startPoint = new List<Tuple<int, int>>() {
                new Tuple<int, int> (0,0)
            };

            for(var ind = 0; ind < gridLimit; ind++) {
        

                roteOptions.Add(startPoint.MoveOnX());
            }


            stopwatch.Stop();

        }
    }
}
