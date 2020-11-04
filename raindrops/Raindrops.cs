using System;

public static class Raindrops
{
    private static class DropSounds {
        public static string Three = "Pling";
        public static string Five = "Plang";
        public static string Seven = "Plong";
    }
    public static string Convert(int number)
    {
        string rd = string.Empty;
        if(number % 3 == 0) 
            rd +=  DropSounds.Three;
        if(number % 5 == 0) 
            rd +=  DropSounds.Five;
        if(number % 7 == 0) 
            rd +=  DropSounds.Seven;
        if (string.IsNullOrWhiteSpace(rd))
            rd = number.ToString();
        return rd;
    }
}