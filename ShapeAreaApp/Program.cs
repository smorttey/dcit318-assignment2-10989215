using System;

namespace ShapeAreaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine("Area of Circle: " + circle.GetArea());
            Console.WriteLine("Area of Rectangle: " + rectangle.GetArea());

            Console.ReadLine(); // Keeps the console window open
        }
    }
}
