using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if(!firstStrand.Length.Equals(secondStrand.Length))
            throw new ArgumentException();
        int sum = 0;
        for(int i = 0; i < firstStrand.Length; i++) {
            sum += firstStrand[i] == secondStrand[i] ? 0 : 1; 
        }
        return sum;
    }
}