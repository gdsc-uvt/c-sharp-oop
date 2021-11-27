using System;

namespace BregaStanislav {

    public class Animal {

        private string name;
        public string Color { get; protected set; }
        
        public Animal() {}
        
        public Animal(string name) {
            
            this.name = name.ToUpper();
            Color = "white";
            Console.WriteLine("new [Animal]");
            
        }

        public Animal(string name, string color) {
            
            this.name = name;
            this.Color = color;
            Console.WriteLine("new [Animal]");
            
        }

        public string GetName() {

            return name;

        }

        public void SetName(string newName) {

            name = newName + '*';

        }

        public virtual void Sound() {
            
            Console.WriteLine("Some animal sound");
            
        }

        public string ToString() {

            return "Animal: " + name + " with Color: " + Color;

        }

    }

}