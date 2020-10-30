using System;
using System.Linq;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        IEnumerable<char> lowerCleanWord = word.ToLower().Where(ch => char.IsLetter(ch));
        return lowerCleanWord.Distinct().Count() == lowerCleanWord.Count();
    }
}
