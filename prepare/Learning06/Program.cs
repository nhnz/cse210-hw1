using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square = new Square("Blue",1);
        //square.GetArea();
        //square.GetColor();
        //Console.WriteLine(square.GetArea() + square.GetColor());

        Rectangle rectangle = new Rectangle("Green",1,4);
        //rectangle.GetArea();
        //rectangle.GetColor();
        //Console.WriteLine(rectangle.GetArea() + rectangle.GetColor());

        Circle circle = new Circle("Blue",10);
       // circle.GetArea();
       // circle.GetColor();
       // Console.WriteLine(circle.GetArea() + circle.GetColor());

        
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine("The area = " + shape.GetArea() + "of a shape colored: " +shape.GetColor());
        }

        

        
        
    }
}