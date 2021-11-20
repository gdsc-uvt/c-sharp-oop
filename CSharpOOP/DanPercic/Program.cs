using System;

namespace DanPercic
{
    // class este un tip de dată, ca un string/int
    class Animal
    {
        // this is a field (class field member)
        // public este un Access Modifier
        public string color;
        // private access modifier previne modificarea numelui din exterior
        private string name;

        public string alias;

        // example of a getter
        public string GetName()
        {
            return name;
        }

        // example of a setter
        public void SetName(string newName)
        {
            name = newName + "*";
        }

        public Animal(){}

        public Animal(string name)
        {
            Console.WriteLine("Constructor");
            this.name = name.ToUpper();
            color = "black";
        }

        public Animal(string name, string color)
        {
            Console.WriteLine("Constructor");
            this.name = name;
            this.color = color;
        }

        public override string ToString()
        {
            return "Animal: " + name + " " + color;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // normal constructor
            var cat = new Animal("Tom");

            // object initializer
            var newCat = new Animal {color = "Ceva nume", alias = "grumpy cat"};
            // similar to this
            var array = new [] { "asd", "asda", "asdasd" };

            Console.WriteLine(cat.ToString());
            var dog = new Animal("Ricky", "white");

            Console.Write(cat.GetName());
            Console.Write(" ");
            Console.WriteLine(cat.color);
            dog.SetName("New name");
            Console.Write(dog.GetName());
            Console.Write(" ");
            Console.WriteLine(dog.color);
            Console.WriteLine("");
            CreateAndPrintAnimalName();
        }

        static void CreateAndPrintAnimalName()
        {
            var donkey = new Animal("Some donkey");
            Console.WriteLine(donkey.GetName());
        }
    }
}
