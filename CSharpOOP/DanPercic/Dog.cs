using System;

namespace DanPercic
{
    public class Dog : Animal, IMamal
    {
        public string owner;
        public int Children { get; set; }
        public string PublicColor => Color;

        public void GiveBirth()
        {
            Children = 5;
        }

        public Dog(string name, string owner) : base(name)
        {
            this.owner = owner;
            Color = "ceva random";
        }

        public Dog(string name, string color, string owner) : base(name, color)
        {
            this.owner = owner;
        }

        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("Bark!");
        }
    }
}
