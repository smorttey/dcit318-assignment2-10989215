using System;

namespace ShapeAreaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool continueGenerating = true;

            while (continueGenerating)
            {
                double radius = random.Next(1, 51);
                double width = random.Next(1, 51);
                double height = random.Next(1, 51);

                Circle circle = new Circle(radius);
                Rectangle rectangle = new Rectangle(width, height);

                Console.WriteLine("Generated values:");
                Console.WriteLine($"Circle Radius: {radius}");
                Console.WriteLine($"Rectangle Width: {width}, Height: {height}");

                Console.WriteLine("Calculations (areas rounded to 2 decimal places):");
                Console.WriteLine("Area of Circle: " + circle.GetArea().ToString("F2"));
                Console.WriteLine("Area of Rectangle: " + rectangle.GetArea().ToString("F2"));

                Console.WriteLine("Do you want to generate new values? (yes/no)");
                string? userResponse = Console.ReadLine()?.ToLower();

                if (userResponse != "yes")
                {
                    continueGenerating = false;
                }
            }
        }
    }
}
