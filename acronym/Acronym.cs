using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase) {
            string phraseLettersOnly =  new string(phrase.Replace('-', ' ').Where(ch => char.IsLetter(ch) || ch == ' ').ToArray()).ToUpper();
            return new string(phraseLettersOnly.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList().Select(str => str[0]).ToArray());
    } 
}

