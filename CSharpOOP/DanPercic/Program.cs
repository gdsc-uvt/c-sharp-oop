using System;
using System.Collections.Generic;

namespace DanPercic
{
    class Program
    {
        static void Main(string[] args)
        {
            // normal constructor
            // var cat = new Animal("Tom");
            //
            // // object initializer
            // var newCat = new Animal {color = "Ceva nume", alias = "grumpy cat"};
            // // similar to this
            // var array = new [] { "asd", "asda", "asdasd" };
            //
            // Console.WriteLine(cat.ToString());
            // var dog = new Animal("Ricky", "white");
            //
            // Console.Write(cat.GetName());
            // Console.Write(" ");
            // Console.WriteLine(cat.color);
            // dog.SetName("New name");
            // Console.Write(dog.GetName());
            // Console.Write(" ");
            // Console.WriteLine(dog.color);
            // Console.WriteLine("");

            // var catWithNameAndColor = new Cat("New Tom", "White");
            var cat = new Cat("Tom");
            cat.Sound();
            Console.WriteLine(cat.ToString());
            var dog = new Dog("Some dog", "Tommy");
            dog.Sound();
            dog.GetName();
            Console.WriteLine(dog.owner);
            var unknownAnimal = new Animal("Unknown");
            var dogAsAnimal = dog as Animal;
            dogAsAnimal.Sound();
            // var dogAsAnimal2 = (Animal)dog;
            // polimorfism
            var animals = new List<Animal> { unknownAnimal, dogAsAnimal, cat, new Animal{Alias = "ceva"} };
            foreach (var animal in animals)
            {
                Console.WriteLine();
                Console.WriteLine(animal.GetName());
                animal.Sound();
                if (animal is Dog)
                {
                    // var usualDog = animal as Dog;
                    Console.WriteLine("It's a DOG!");
                    Console.WriteLine(((Dog)animal).owner);
                    Console.WriteLine(animal.ToString());
                }
                else if(animal is Cat usualCat)
                {
                    Console.WriteLine("It's a CAT!");
                }
                else
                {
                    Console.WriteLine("Unknown animal!");
                }
            }

            var mamals = new List<IMamal> { dog, cat };
            foreach (var mamal in mamals)
            {
                mamal.GiveBirth();
                Console.WriteLine(mamal.Children);
            }

            Console.WriteLine(dog.Children);
            Console.WriteLine(cat.Children);
        }
    }
}
