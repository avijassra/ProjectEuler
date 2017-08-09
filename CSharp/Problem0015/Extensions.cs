namespace System.Collections.Generic
{
    using System;
    using System.Linq;

    public static class ListExtension
    {
        public static List<Tuple<int, int>> MoveOnX(this List<Tuple<int, int>> routeOption) 
        {
            var newRouteOption = routeOption.Select(x => new Tuple<int, int>(x.Item1, x.Item2)).ToList();
            var lastPoint = newRouteOption.Last();

            newRouteOption.Add(new Tuple<int, int>(lastPoint.Item1 + 1, lastPoint.Item2));

            return newRouteOption;
        }

        public static List<Tuple<int, int>> MoveOnY(this List<Tuple<int, int>> routeOption) 
        {
            var newRouteOption = routeOption.Select(x => new Tuple<int, int>(x.Item1, x.Item2)).ToList();
            var lastPoint = newRouteOption.Last();

            newRouteOption.Add(new Tuple<int, int>(lastPoint.Item1, lastPoint.Item2 + 1));

            return newRouteOption;
        }
    }
}