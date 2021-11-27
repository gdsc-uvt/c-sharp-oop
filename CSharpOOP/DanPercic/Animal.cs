using System;

namespace DanPercic
{
// class este un tip de dată, ca un string/int
// base class
    public class Animal
    {
        // this is a field (class field member)
        // public este un Access Modifier
        private string alias;
        public string Alias
        {
            get => alias;
            set {
                if (alias is not null)
                {
                    return;
                }
                else
                {
                    this.alias = value;
                }
            }
        }

        // înseamnă că poate fi accesat doar în clasele derivate
        protected string Color { get; set; }

        // private access modifier previne modificarea numelui din exterior
        private string name;

        // example of a getter
        public string GetName()
        {
            return name;
        }

        // example of a setter
        public void SetName(string value)
        {
            name = value + "*";
        }

        public Animal(){}

        public Animal(string name)
        {
            Console.WriteLine("[ANIMAL] Ctor cu nume");
            this.name = name.ToUpper();
            Color = "black";
        }

        public Animal(string name, string color)
        {
            Console.WriteLine("[ANIMAL] Ctor cu nume și culoare");
            this.name = name;
            this.Color = color;
        }

        // virtual -> face ca metoda să poată fi suprascrisă în clasa derivată
        public virtual void Sound()
        {
            Console.WriteLine("Some animal sound");
        }

        public override string ToString()
        {
            return "Animal: " + name + " " + Color;
        }
    }
}
