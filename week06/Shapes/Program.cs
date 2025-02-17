using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 20));
        shapes.Add(new Rectangle("Green", 15, 20));
        shapes.Add(new Circle("Blue", 10));


        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} {shape.GetArea()}");
        }


    }
}