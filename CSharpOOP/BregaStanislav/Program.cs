using System;

namespace BregaStanislav
{

    class Animal
    {

        private string name;
        public string color;

        public string GetName()
        {

            return name;

        }

        public void SetName(string newName)
        {

            name = newName + '*';

        }
        
        public Animal(string name)
        {
            
            this.name = name.ToUpper();
            color = "black";
            Console.WriteLine("new object");
            
        }

        public Animal(string name, string color)
        {
            
            this.name = name;
            this.color = color;
            Console.WriteLine("new object");
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            var cat = new Animal("Tom");
            var dog = new Animal("Bobby", "White");
            dog.SetName("NewName");
            
            Console.WriteLine(cat.GetName() + ' ' + cat.color);
            Console.WriteLine(dog.GetName() + ' ' + dog.color);

        }
    }
}
