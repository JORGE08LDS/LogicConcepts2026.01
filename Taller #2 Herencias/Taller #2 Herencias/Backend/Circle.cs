namespace GeometricFigures.Backend;

public class Circle : GeometricFigure
{
    private double _r;

    public double R
    {
        get => _r;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Radius must be positive");
            _r = value;
        }
    }

    public Circle(string name, double r) : base(name)
    {
        R = r;
    }

    public override double GetArea()
    {
        return Math.PI * R * R;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }
    public bool ValidateR()
    {
        return R > 0;
    }

}
