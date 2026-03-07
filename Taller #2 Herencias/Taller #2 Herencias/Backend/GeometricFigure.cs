namespace GeometricFigures.Backend;

public abstract class GeometricFigure
{
    public string Name { get; set; }

    public GeometricFigure(string name)
    {
        Name = name;
    }

    public abstract double GetArea();

    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-18} => Area.....: {GetArea(),12:N5}     Perimeter: {GetPerimeter(),12:N5}";
    }
}
