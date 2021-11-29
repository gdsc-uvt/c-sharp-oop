using System;
using System.Drawing;

namespace BaciuAlex
{
    public class Dog : Animal, IMamal
    {
        public string owner;
        public int Children { get; set; }
        public string PublicColor => Color;

        public Dog() : base()
        {
            
        }

        public Dog(string name, string owner) : base(name)
        {
            this.owner = owner;
        }

        public Dog(string name, string color, string owner) : base(name, color)
        {
            this.owner = owner;
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Dog Sound");
        }
        
        public void GiveBirth()
        {
            Children = 5;
        }
    }
}