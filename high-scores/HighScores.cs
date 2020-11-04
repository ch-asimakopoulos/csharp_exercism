using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> hs;
    public HighScores(List<int> list)
    {
        hs = list;
    }

    public List<int> Scores() => hs;

    public int Latest() => hs.Last();

    public int PersonalBest() => hs.Max();

    public List<int> PersonalTopThree() => hs.OrderByDescending(ch => ch).Take(3).ToList();
}