using HomeWorkLibrary;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Ex1()
        {
            var animal = new Cat(true);

            var another = new Dog("Test");
            Console.WriteLine(animal);
            animal.Fly();
            Console.WriteLine(Animal.Count);
        }

        static void Main(string[] args)
        {
            Animal dog = new Dog("Red");
            Animal cat = new Cat(true);

            Animal[] animals = new Animal[2];
            animals[0] = dog;
            animals[1] = cat;
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Sound());
            }
        }
    }
}
