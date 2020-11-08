using System;
using System.Collections.Generic;
using System.Linq;
public static class ProteinTranslation
{

    private static Dictionary<string, string> codonToProtein  = new Dictionary<string,string>() 
    {
        {"AUG", "Methionine"},
        {"UUA", "Leucine"},
        {"UUG", "Leucine"},
        {"UUU", "Phenylalanine"},
        {"UUC", "Phenylalanine"},
        {"UCU", "Serine"},
        {"UCC", "Serine"},
        {"UCA", "Serine"},
        {"UCG", "Serine"},
        {"UAU", "Tyrosine"},
        {"UAC", "Tyrosine"},
        {"UGU", "Cysteine"},
        {"UGC", "Cysteine"},
        {"UGG", "Tryptophan"},
        {"UAA", "STOP"},
        {"UAG", "STOP"},
        {"UGA", "STOP"}
    };
    public static string[] Proteins(string strand)
    {
        string stopSequence = "STOP";
        List<string> proteins = new List<string>();
        for(int i = 0; i < strand.Length - 2; i+=3) 
        {
            var threeChars = strand[i..(i+3)].ToString();
            var protein = codonToProtein[threeChars];
            if(protein == stopSequence)
                return proteins.ToArray();
            proteins.Add(protein);
        }
        return proteins.ToArray();
    }
}