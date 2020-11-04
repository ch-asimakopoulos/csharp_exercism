using System;

public struct ComplexNumber
{
    public double r { get; set; }
    public double i { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        r = real;
        i = imaginary;
    }

    public double Real()
    {
        return r;
    }

    public double Imaginary()
    {
        return i;
    }

    public ComplexNumber Mul(ComplexNumber other) => new ComplexNumber(r * other.r - i * other.i, i * other.r + r * other.i);

    public ComplexNumber Add(ComplexNumber other) => new ComplexNumber(r + other.r, i + other.i);

    public ComplexNumber Sub(ComplexNumber other) => new ComplexNumber(r - other.r, i - other.i);

    public ComplexNumber Div(ComplexNumber other) => new ComplexNumber((r * other.r + i * other.i) / (other.r * other.r + other.i * other.i),
    (i * other.r - r * other.i)/(other.r * other.r + other.i * other.i));
    public double Abs()
    {
        return Math.Sqrt(Math.Pow(r,2) + Math.Pow(i,2));
    }

    public ComplexNumber Conjugate()
    {
        return new ComplexNumber(r, -i);
    }
    
    public ComplexNumber Exp() => new ComplexNumber(Math.Exp(r) * Math.Cos(i),Math.Exp(r) * Math.Sin(i));
}