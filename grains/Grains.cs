using System;

public static class Grains
{
    public static ulong Square(int n)
    {   
        if(n > 64 || n < 1) throw new ArgumentOutOfRangeException();  
        return (ulong)Math.Pow(2,n-1);
    }

    public static ulong Total()
    {
        return (ulong) Math.Pow(2,65) - 1;
    }
}