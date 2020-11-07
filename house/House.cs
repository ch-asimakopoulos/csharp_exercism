﻿using System;
using System.Collections.Generic;
using System.Linq;

public static class House
{
    private static readonly IReadOnlyList<(string, string)> phrases = new List<(string, string)>
    {
        ("horse and the hound and the horn","belonged to"),
        ("farmer sowing his corn","kept"),
        ("rooster that crowed in the morn","woke"),
        ("priest all shaven and shorn","married"),
        ("man all tattered and torn","kissed"),
        ("maiden all forlorn","milked"),
        ("cow with the crumpled horn","tossed"),
        ("dog","worried"),
        ("cat","killed"),
        ("rat","ate"),
        ("malt","lay in"),
        ("house","Jack built."),
    };

    public static string Recite(int verseNumber)
        => $"This is{(String.Concat(phrases.TakeLast(verseNumber).Select(ch => $" the {ch.Item1} that {ch.Item2}")))}";

    public static string Recite(int startVerse, int endVerse)
        => String.Join("\n", Enumerable.Range(startVerse, endVerse - startVerse + 1).Select(ch => Recite(ch)));
}