using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) 
            return false;
        return input.ToLower().Where(ch => Char.IsLetter(ch)).Distinct().Count().Equals(26);
    }
}
