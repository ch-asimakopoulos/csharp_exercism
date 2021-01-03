using System;
using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old) => old
                                        .SelectMany(kvp => kvp.Value.Select(ch => new { Key = ch, Value = kvp.Key }))
                                        .ToDictionary(ch => ch.Key.ToLower(), ch => ch.Value);
}