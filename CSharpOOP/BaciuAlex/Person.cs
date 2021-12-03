using System;

namespace BaciuAlex
{
    public class Person : Entity
    {
        public string Name { get; set; } = "Alex";
        public int Age { get; }

        public Person()
        {
            
        }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public virtual void Work()
        {
            Console.WriteLine("Working...");
        }
    }
}