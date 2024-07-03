using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Fractions
{

  
    private int _numerator = 1;
    private int _denominator = 1;


    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    public int Denominator
    {
        get { return _denominator; }
        set { _denominator = value; }
    }
    public Fractions()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor with numerator only
    public Fractions(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor with numerator and denominator
    public Fractions(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    


    public void Display()
    {
        Console.WriteLine($"{_numerator}/{_denominator}");
    }
}