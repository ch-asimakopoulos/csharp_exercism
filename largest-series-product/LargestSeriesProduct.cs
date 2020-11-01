using System;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        if(span<0)
            throw new ArgumentException();
        if(span == 0)
            return 1;
        if(digits.Any(ch => !char.IsDigit(ch)))
            throw new ArgumentException();
        if(span > digits.Length)
            throw new ArgumentException();
        long max = -1;
        for(int i = 0; i <= digits.Length - span; i++) {
            long mul = digits.Skip(i).Take(span).Aggregate(1, (ch,th) => (int)char.GetNumericValue(th) * ch, r => (long)r);
            if (mul>max)
                max = mul;
        }
        return max;
    }
}