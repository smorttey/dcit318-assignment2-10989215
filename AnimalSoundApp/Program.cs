using System;

namespace AnimalSoundApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.WriteLine("Animal sound:");
            genericAnimal.MakeSound(); // Should print "Some generic sound"

            Console.WriteLine("Dog sound:");
            dog.MakeSound(); // Should print "Bark"

            Console.WriteLine("Cat sound:");
            cat.MakeSound(); // Should print "Meow"

            Console.ReadLine(); // Keeps the console window open
        }
    }
}
