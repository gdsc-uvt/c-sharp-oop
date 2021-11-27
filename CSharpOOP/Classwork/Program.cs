using System;
using System.Collections.Generic;

namespace BregaStanislav
{

    
    class Program
    {
        static void Main(string[] args)
        {

            // var cat = new Animal("Tom");
            // var dog = new Animal("Bobby", "White");
            // dog.SetName("NewName");
            //
            // Console.WriteLine(cat.GetName() + ' ' + cat.color);
            // Console.WriteLine(dog.GetName() + ' ' + dog.color);

            var cat = new Cat("Tom");
            // Console.WriteLine(cat.ToString());
            // cat.Sound();
            var catWithName = new Cat("new Tom", "Black");

            var dog = new Dog("Some dog", "Tommy");
            // dog.Sound();
            // Console.WriteLine(dog.GetName());

            var unknownAnimal = new Animal("Unknown");
            var dogAsAnimal = (Animal) dog;

            var animals = new List<Animal> {unknownAnimal, dogAsAnimal, cat};

            foreach (var animal in animals) {

                Console.WriteLine();
                Console.WriteLine(animal.ToString());
                animal.Sound();

                if (animal is Dog usualDog) {
                    
                    Console.WriteLine("It's a DOG!");
                    Console.WriteLine("Has an owner: {0}", usualDog.GetOwner());
                    
                }
                else if (animal is Cat) {
                    
                    Console.WriteLine("It's a Cat!");
                    
                }
                
            }
            
            Console.WriteLine();

            var mammals = new List<IMammal> {dog, cat};

            foreach (var mammal in mammals) {

                mammal.GiveBirth();
                Console.WriteLine(mammal.Children);

            }

        }
    }
}