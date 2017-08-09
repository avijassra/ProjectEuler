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
            var gridLimit = 3;

            var routeOptions = new List<List<Tuple<int, int>>>();
            var startPoint = new List<Tuple<int, int>>() {
                new Tuple<int, int> (0,0)
            };

            routeOptions.Add(startPoint);

            for(var ind = 0; ind < gridLimit; ind++) {
                var copyOfRouteOptions = routeOptions.Select(x => x).ToList();
                
                foreach(var opt in routeOptions) {
                    var optX = opt.MoveOnX();
                    var optY = opt.MoveOnY();
                }

                
            }


            stopwatch.Stop();

        }
    }
}
