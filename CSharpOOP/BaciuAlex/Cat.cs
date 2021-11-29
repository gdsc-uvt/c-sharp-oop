using System;

namespace BaciuAlex
{
    public class Cat : Animal, IMamal
    {
        public Cat() : base()
        {
            
        }
        
        public Cat(string name) : base(name)
        {
            Console.WriteLine("constructor cu nume");
        }

        public Cat(string name, string color) : base(name, color)
        {
            Console.WriteLine("constructor cu nume si culoare");
        }

        public override void AnimalSound()
        {
            base.AnimalSound();
            Console.WriteLine("Cat sound");
        }
        
        public bool IsCastrated { get; set; }
        public int Children { get; set; }

        public void GiveBirth()
        {
            Children = 2;
        }
    }
}