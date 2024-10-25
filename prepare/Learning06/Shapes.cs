using System.Drawing;
using System.Dynamic;
using System.Formats.Asn1;

public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    //public virtual double GetArea()
    //{
    //    return 1;
    //}

    public abstract double GetArea();
}