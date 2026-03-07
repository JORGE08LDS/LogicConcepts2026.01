namespace GeometricFigures.Backend;

public class Rectangle : Square
{
    private double _b;

    public double B
    {
        get => _b;
        set
        {
            if (value <= 0)
                throw new ArgumentException("B must be positive");
            _b = value;
        }
    }

    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = b;
    }

    public override double GetArea()
    {
        return A * B;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }
    public bool ValidateB()
    {
        return B > 0;
    }

}
