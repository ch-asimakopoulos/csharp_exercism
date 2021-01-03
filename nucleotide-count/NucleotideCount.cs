using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
   // public static IDictionary<char, int> Count(string sequence) => sequence.GroupBy(ch => ch).ToDictionary(ch => ch.Key, ch=> ch.Count());
    
      public static IDictionary<char, int> Count(string sequence) {

        Dictionary<char, int> nucleotideCount = new Dictionary<char, int> {{'A', 0} , {'C', 0}, {'G', 0}, {'T', 0}}; 
        foreach(char ch in sequence) 
        {
            if(!nucleotideCount.ContainsKey(ch))
                throw new System.ArgumentException();
            nucleotideCount[ch]++;
        }
        return nucleotideCount;
      }
}