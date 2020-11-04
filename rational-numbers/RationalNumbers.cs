using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        return Math.Pow((double) realNumber, (double) (r.n)/(r.d) );
    }
}

public struct RationalNumber
{
    public int n, d;
    private static int GCD(int a, int b)
{
    while (a != 0 && b != 0)
    {
        if (a > b)
            a %= b;
        else
            b %= a;
    }

    return a | b;
}
    public RationalNumber(int numerator, int denominator)
    {
        n = numerator;
        d = denominator;
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2) {
        int n = (r1.n * r2.d) + (r1.d * r2.n);
        int d = r2.d * r1.d;
        return new RationalNumber(n,d).Reduce();        
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        int n = (r1.n * r2.d) - (r1.d * r2.n);
        int d = r2.d * r1.d;        
        return new RationalNumber(n,d).Reduce();        

    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        int n = r1.n * r2.n;
        int d = r2.d * r1.d;
        return new RationalNumber(n,d).Reduce();        
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        int n = r1.n * r2.d;
        int d = r2.n * r1.d;
        if (n < 0 && d < 0) {
            n = Math.Abs(n);
            d = Math.Abs(d);
        }
        return new RationalNumber(n,d).Reduce();        
    }

    public RationalNumber Abs()
    {
        return new RationalNumber(Math.Abs(n), Math.Abs(d));
    }

    public RationalNumber Reduce()
    {
        int gcd = GCD(Math.Abs(n), Math.Abs(d));
        if(n > 0 && d < 0) {
            n = -n;
            d = Math.Abs(d);
        }
        return new RationalNumber(n/gcd, d/gcd);    
    }

    public RationalNumber Exprational(int power)
    {
        int a,b, p;
        if(power < 0) {
            a = d;
            b = n;
            p = Math.Abs(power);
        }
        else {
            a = n;
            b = d;
        }
        return new RationalNumber((int) Math.Pow(n, power), (int) Math.Pow(d, power)).Reduce();
    }

    public double Expreal(int baseNumber)
    {
        return Math.Pow((double) baseNumber, (double) n/d);
    }
}