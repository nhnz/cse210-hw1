using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    
    public Rectangle(string color, double lenght, double width) : base(color)
    {
        _lenght = lenght;
        _width = width;
    }
    


    public override double GetArea()
    {
        return _lenght * _width;
    }

}