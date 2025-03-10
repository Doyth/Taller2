using System;
using Geometry;

public class Rhombus : Square
{
 

    private double _d1;

    public double D1
    {
        get => _d1;
        set => _d1 = ValidateD1(value);
    }
    private double ValidateD1(double diagonal)
    {
        if (diagonal < 0)
        {
            throw new ArgumentException($"La diagonal {diagonal}, no es valida.");
        }
        return diagonal;
    }

    private double _d2;

    public double D2
    {
        get => _d2;
        set => _d2 = ValidateD2(value);

    }
    private double ValidateD2(double diagonal)
    {
        if (diagonal < 0)
        {
            throw new ArgumentException($"El lado {diagonal}, no es valido.");
        }
        return diagonal;
    }
    public Rhombus(string name, double side, double diagonal1, double diagonal2) : base(name,side)
    {
       
        _d1 = ValidateD1(diagonal1);
        _d2 = ValidateD2(diagonal2);
    }

    public override double GetArea()
    {
        return _d1 * _d2 / 2;
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }
}