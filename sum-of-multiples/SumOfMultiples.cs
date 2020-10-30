using System;
using System.Linq;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max) 
    {
        return Enumerable.Range(0, max).Where(ch => multiples.Where(ml => ch == 0 || (ml > 0 && ch % ml == 0))
            .Any()).Distinct().Sum();
    }
}