using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number < 1)
            throw new ArgumentOutOfRangeException();
        int steps = 0, cltz = number;
        while(cltz > 1) {
            cltz = cltz % 2 == 0 ? cltz / 2 : 3 * cltz + 1;
            steps++;
        }
        return steps;
    }
}