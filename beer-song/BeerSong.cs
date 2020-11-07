using System;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        string result = "";
        for (int i = 1; i <= takeDown&&startBottles>=0; i++)
        {
            if (startBottles == 0)
            {
                result += "No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.";
                break;
            }
            else if (startBottles == 2)
            {
                result += $"{startBottles.ToString()} bottles of beer on the wall, {startBottles.ToString()} bottles of beer.\nTake one down and pass it around, {(startBottles - 1).ToString()} bottle of beer on the wall.";
            }
            else if (startBottles == 1)
            {
                result += $"{startBottles.ToString()} bottle of beer on the wall, {startBottles.ToString()} bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.";
            }
            else
            {
                result += $"{startBottles.ToString()} bottles of beer on the wall, {startBottles.ToString()} bottles of beer.\nTake one down and pass it around, {(startBottles - 1).ToString()} bottles of beer on the wall.";
            }
            if (i < takeDown)
            {
                result += "\n\n";
            }
            startBottles =startBottles- 1;
        }        
        return result;
    }
}