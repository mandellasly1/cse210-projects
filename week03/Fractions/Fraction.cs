using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor 1: No parameters (default 1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: One parameter (n/1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor 3: Two parameters (n/d)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters
    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    // Setters
    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Method: Fraction string
    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    // Method: Decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}