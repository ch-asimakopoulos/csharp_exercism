using System;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        char[] numberChrArr = number.ToString().ToCharArray();
        return number == numberChrArr.Sum((ch) => (int) Math.Pow(char.GetNumericValue(ch), numberChrArr.Length));

    }
}