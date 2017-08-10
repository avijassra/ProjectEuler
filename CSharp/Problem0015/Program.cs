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
            var gridLimit = 2;
            var allOptionsNotExplored = true;

            var routeOptions = new List<List<Tuple<int, int>>>();
            var startPoint = new List<Tuple<int, int>>() {
                new Tuple<int, int> (0,0)
            };

            routeOptions.Add(startPoint);

            while(allOptionsNotExplored) {
                var copyOfRouteOptions = routeOptions.Select(x => x).ToList();
                routeOptions = new List<List<Tuple<int, int>>>();
                
                foreach(var opt in copyOfRouteOptions) {
                    var newMoveOnX = opt.MoveOnX(gridLimit);
                    routeOptions.Add(newMoveOnX);
                    var newMoveOnY = opt.MoveOnY(gridLimit);
                    routeOptions.Add(newMoveOnY);

                    var xLastPoint = newMoveOnX.Last();
                    var yLastPoint = newMoveOnY.Last();

                    allOptionsNotExplored = xLastPoint.Item1 < gridLimit || 
                                                xLastPoint.Item2 < gridLimit || 
                                                yLastPoint.Item1 < gridLimit || 
                                                yLastPoint.Item2 < gridLimit;
                    Console.WriteLine($"allOptionsNotExplored: {allOptionsNotExplored}");

                    Console.WriteLine(string.Join(" -> ", newMoveOnX.Select(x => string.Format($"({x.Item1}, {x.Item2})"))));
                    Console.WriteLine(string.Join(" -> ", newMoveOnY.Select(x => string.Format($"({x.Item1}, {x.Item2})"))));
                }
            }

            foreach(var opt in routeOptions) {
                Console.WriteLine(string.Join(" -> ", opt.Select(x => string.Format($"({x.Item1}, {x.Item2})"))));
            }

            stopwatch.Stop();

            Console.WriteLine($"Total options: {routeOptions.Count} (time {stopwatch.Elapsed.TotalMilliseconds}ms)");
        }
    }
}
