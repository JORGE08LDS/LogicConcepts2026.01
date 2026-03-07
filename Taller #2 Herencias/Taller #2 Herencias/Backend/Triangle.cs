namespace GeometricFigures.Backend;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;

    public double C { get => _c; set => _c = value; }
    public double H { get => _h; set => _h = value; }

    public Triangle(string name, double a, double b, double c, double h)
        : base(name, a, b)
    {
        C = c;
        H = h;
    }

    public override double GetArea()
    {
        return (B * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C;
    }
    public bool ValidateC()
    {
        return C > 0;
    }

    public bool ValidateH()
    {
        return H > 0;
    }

}
