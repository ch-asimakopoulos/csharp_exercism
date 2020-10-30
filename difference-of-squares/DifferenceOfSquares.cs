using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        return max * max * (max + 1) * (max + 1) / 4;
    }

    public static int CalculateSumOfSquares(int max)
    {
        return max * (max + 1) * (2*max + 1) / 6;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}