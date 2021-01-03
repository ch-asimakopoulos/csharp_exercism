using System;
using System.Collections.Generic;
using System.Linq;

public static class ParallelLetterFrequency
{
    public static Dictionary<char, int> Calculate(IEnumerable<string> texts) => texts
                        .SelectMany(str => str.ToLower().Where(ch => char.IsLetter(ch)))
                        .GroupBy(ch=>ch).ToDictionary(ch => ch.Key, freq => freq.Count());
}