using System;
using System.Collections.Generic;
public static class ResistorColorTrio
{
    public static string Label(string[] colors)
    {
        Dictionary<string, int> resistanceCode = new Dictionary<string, int>()
        {
            {"black", 0},
            {"brown", 1},
            {"red", 2},
            {"orange", 3},
            {"yellow", 4},
            {"green", 5},
            {"blue", 6},
            {"violet", 7},
            {"grey", 8},
            {"white", 9}
        };

        int resistanceInOhms = (10 * resistanceCode[colors[0]] + resistanceCode[colors[1]]) * (int) Math.Pow(10, resistanceCode[colors[2]]); 

        if(resistanceInOhms / 1000 > 1) { 
            return (resistanceInOhms / 1000).ToString() + " kiloohms";
        }    
            return resistanceInOhms.ToString() + " ohms";
    }
}
