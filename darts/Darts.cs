using System;

public static class Darts
{
    private class DartsCicle {
        public const int Outer = 10;
        public const int Middle = 5;
        public const int Inner = 1;
    }

    private class DartPoints {
        public const int MissedEmAll = 0;
        public const int HitOuterCircle = 1;
        public const int HitMiddleCircle = 5;
        public const int Bullseye = 10;
    }
    private static bool inRadius(int radius, double x, double y) => radius * radius >= x * x + y * y;
    public static int Score(double x, double y)
    {
        if(!inRadius(DartsCicle.Outer, x, y))
            return DartPoints.MissedEmAll;
        if(!inRadius(DartsCicle.Middle, x,y))
            return DartPoints.HitOuterCircle;
        if(!inRadius(DartsCicle.Inner, x,y))
            return DartPoints.HitMiddleCircle;
        return DartPoints.Bullseye;
    }
}
