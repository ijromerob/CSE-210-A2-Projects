using System;

class Program
{
    static void Main(string[] args)
    {
        // Shapes created
        Circle circle1 = new Circle(3,"red");
        Rectangle rectangle1 = new Rectangle(5,3,"blue");
        Square square1 = new Square(7,"Orange");

        //lists of shapes adding each shape
        List<Shape> shapes = new List<Shape>();
        shapes.Add(circle1);
        shapes.Add(rectangle1);
        shapes.Add(square1);

        foreach(Shape s in shapes)
        {
            Console.WriteLine($"The area is {s.GetArea()}");
            Console.WriteLine($"The color is {s.GetColor()}");
            Console.WriteLine("");
        }

    }
}