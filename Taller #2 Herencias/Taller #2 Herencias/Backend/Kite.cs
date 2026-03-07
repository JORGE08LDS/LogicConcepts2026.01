namespace GeometricFigures.Backend;

public class Kite : Rhombus
{
    private double _b;

    public double B { get => _b; set => _b = value; }

    public Kite(string name, double a, double b, double d1, double d2)
        : base(name, a, d1, d2)
    {
        B = b;
    }

    public override double GetArea()
    {
        return (D1 * D2) / 2;
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
