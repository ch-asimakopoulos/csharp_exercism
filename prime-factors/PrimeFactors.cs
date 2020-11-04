using System;
using System.Collections.Generic;
using System.Linq;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        List<long> primes = new List<long>();
        while (number % 2L == 0L) 
        { 
            primes.Add(2L);
            number /= 2L; 
        } 
  
        // n must be odd at this point. So we can 
        // skip one element (Note i = i +2) 
        for (long i = 3L; i <= Math.Sqrt(number); i+= 2L) 
        { 
            // While i divides n, print i and divide n 
            while (number % i == 0L) 
            { 
                primes.Add(i);
                number /= i; 
            }
            if(number < i)
                break; 
        }

        if(number > 2L) {
            primes.Add(number);
        }
        return primes.ToArray();
    }
}