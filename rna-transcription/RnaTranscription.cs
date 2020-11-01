using System;
using System.Linq;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide) => new string(nucleotide.Select(ch => 
    ch == 'G' ? 'C' : ch == 'C' ? 'G' : ch == 'T' ? 'A' : 'U').ToArray());
}