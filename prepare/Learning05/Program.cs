using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
        
        Square square = new Square("blue", 4);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("yellow", 4, 3);
        shapes.Add(rectangle);

        Circle circle = new Circle("purple", 5);
        shapes.Add(circle);

        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}