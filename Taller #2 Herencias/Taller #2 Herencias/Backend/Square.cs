namespace GeometricFigures.Backend;

public class Square : GeometricFigure
{
    private double _a;

    public double A
    {
        get => _a;
        set
        {
            if (value <= 0)
                throw new ArgumentException("A must be positive");
            _a = value;
        }
    }

    public Square(string name, double a) : base(name)
    {
        A = a;
    }

    public override double GetArea()
    {
        return A * A;
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }
    public bool ValidateA()
    {
        return A > 0;
    }

}

