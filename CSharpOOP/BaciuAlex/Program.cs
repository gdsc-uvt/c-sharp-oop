// See https://aka.ms/new-console-template for more information
using System;

namespace BaciuAlex
{
    class Animal
    {
        private string name;
        public string color;

        public Animal(string name)
        {
            this.name = name;
            this.color = "black";
        }
        
        public Animal(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public string GetName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Animal: " + name + " " + color;
        }
        
        ~Animal()
        {
            Console.WriteLine("Destructor");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        { 
            Animal cat = new Animal("Tom");

            Animal dog = new Animal("Sasha", "Gri");
            
            cat.setName("Pisica nume nou");
            
            Console.WriteLine(cat.GetName());
            Console.WriteLine(cat.color);
            
            Console.WriteLine(dog.GetName());
            Console.WriteLine(dog.color);
            
            Console.WriteLine(dog.ToString());

        }
    }
    
    
}
