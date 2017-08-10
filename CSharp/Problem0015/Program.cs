namespace Problem0015
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            const int gridSize = 3;

            var grid = new long[gridSize + 1, gridSize + 1];

            for(var i = 0; i < gridSize; i++) {
                grid[i, gridSize] = 1;
                grid[gridSize, 1] = 1;
            }

            //for(var i = gridSize - 1)

            stopwatch.Stop();

            //Console.WriteLine($"Total options: {routeOptions.Count} (time {stopwatch.Elapsed.TotalMilliseconds}ms)");
        }
    }
}
