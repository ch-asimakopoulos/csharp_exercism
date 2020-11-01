using System;

public class SpaceAge
{
    public SpaceAge(int seconds)
    {
        ageInSeconds = seconds;
    }

    private static class PlanetYearToEarthYearRatio { 
        
        public const double Mercury = 0.2408467;
        public const double  Venus = 0.61519726;
        public const double Mars = 1.8808158;
        public const double Jupiter = 11.862615;
        public const double Saturn = 29.447498;
        public const double Uranus = 84.016846;
        public const double Neptune = 164.79132;
    }

    private int ageInSeconds;

    private int earthYearInSeconds = 31557600;
    public double OnEarth() => (double) ageInSeconds / earthYearInSeconds;

    public double OnMercury() => OnEarth() / PlanetYearToEarthYearRatio.Mercury;

    public double OnVenus() => OnEarth() / PlanetYearToEarthYearRatio.Venus;

    public double OnMars() => OnEarth() / PlanetYearToEarthYearRatio.Mars;

    public double OnJupiter() => OnEarth() / PlanetYearToEarthYearRatio.Jupiter;

    public double OnSaturn() => OnEarth() / PlanetYearToEarthYearRatio.Saturn;

    public double OnUranus() => OnEarth() / PlanetYearToEarthYearRatio.Uranus;

    public double OnNeptune() => OnEarth() / PlanetYearToEarthYearRatio.Neptune;
}