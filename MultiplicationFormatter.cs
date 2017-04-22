using System.Collections.Generic;
using static System.Linq.ParallelEnumerable;

public static class MultiplicationFormatter
{
    public static List<string> Format(List<int> list)
        => list.AsParallel()
         .Select(Extensions.MultiplyBy2)
         .Zip(Range(1, list.Count), (val, counter) => $"{counter} x 2 = {val}")
         .ToList();
}