using System;
using System.Linq;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (numbers.Length < sliceLength)
            throw new ArgumentException();
        if (string.IsNullOrWhiteSpace(numbers))
            throw new ArgumentException();
        if (sliceLength<=0)
            throw new ArgumentException();
        IEnumerable<char[]> slices = new List<char[]> { numbers.Take(sliceLength).ToArray() };
        for(int i = 1; i <= numbers.Length-sliceLength; i++) {
            slices = slices.Append(numbers.Skip(i).Take(sliceLength).ToArray());
        }
        return slices.Select(ch => new string(ch)).ToArray();
    }
}