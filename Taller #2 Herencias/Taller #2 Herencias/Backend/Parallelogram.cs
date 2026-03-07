namespace GeometricFigures.Backend;

public class Parallelogram : Rectangle
{
    private double _h;

    public double H
    {
        get => _h;
        set => _h = value;
    }

    public Parallelogram(string name, double a, double b, double h)
        : base(name, a, b)
    {
        H = h;
    }

    public override double GetArea()
    {
        return A * H;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    public bool ValidateH()
    {
        return H > 0;
    }
}
