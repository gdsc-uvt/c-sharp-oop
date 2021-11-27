using System;

namespace DanPercic
{
    // derived class
    // or superclass
    public class Cat : Animal, IMamal
    {
        // properties
        public bool IsCastrated { get; set; }
        // public bool blabla;
        // public bool IsCastrated
        // {
        //     get { return blabla;}
        //     private set { blabla = value; }
        // }

        public int Children { get; set; }

        public void GiveBirth()
        {
            Children = 2;
        }

        public Cat() : base()
        {
            this.IsCastrated = false;
            Console.WriteLine(IsCastrated);
            SetName("adsda");
            Console.WriteLine(GetName());
        }

        public Cat(string name) : base(name)
        {
            Console.WriteLine("[CAT] Ctor cu nume");
        }

        public Cat(string name, string color) : base(name, color)
        {
            Console.WriteLine("[CAT] Ctor cu nume și culoare");
        }

        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("Miew");
        }
    }
}
