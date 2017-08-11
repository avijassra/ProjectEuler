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
            const int gridSize = 20;

            var grid = new long[gridSize + 1, gridSize + 1];

            for(var i = 0; i < gridSize; i++) {
                grid[i, gridSize] = 1;
                grid[gridSize, i] = 1;
            }

            for(var i = gridSize - 1; i >= 0; i--) {
                for(var j = gridSize - 1; j >= 0; j--) {
                    grid[i,j] = grid[i, j + 1] + grid[i + 1, j]; 
                }
            }

            stopwatch.Stop();

            Console.WriteLine($"Total options: {grid[0,0]} (time {stopwatch.ElapsedMilliseconds}ms)");
        }
    }
}
