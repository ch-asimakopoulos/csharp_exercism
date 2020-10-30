using System;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        int aliquotSum = Enumerable.Range(1,number-1).Where(nm => 0 == number % nm).Sum() - number;
        if (aliquotSum == 0)
            return Classification.Perfect;
        if (aliquotSum > 0)
            return Classification.Abundant;
        return Classification.Deficient;
    }
}
