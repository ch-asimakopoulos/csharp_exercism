using System;
using System.Collections.Generic;
using System.Linq;
public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach(T itm in collection) {
            if(predicate(itm))
                yield return itm;
        }
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach(T itm in collection) {
            if(!predicate(itm))
                yield return itm;
        }
    }
}