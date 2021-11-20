using System;
using System.Security.Authentication.ExtendedProtection;

namespace NiculescuRobert
{
    class Animal
    {
        
        private string name;
        public string color;
        public string alias;
        public string GetName()
        {
            return name;
            
        }
        
        public void SetName(string name)
        {
            this.name = name + '*';
        }
        public Animal(string name)
        {
            this.name = name;
        }

        public Animal(string name, string color)
        {
            Console.WriteLine("constructor");
            this.name = name;
            this.color = color;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal tiger = new Animal("Coll");
            var anim1 = new Animal("Ryn", "black");
            Console.WriteLine(anim1.color + anim1.name);
            
        
        
            Console.WriteLine("Destructor");
            var newcat=new Animal{color ="ceva nume",alias ="grumpy cat"}
        }
           
        
    }
}