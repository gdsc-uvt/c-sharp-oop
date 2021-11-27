using System;

namespace BregaStanislav {

    public class Dog : Animal, IMammal {

        private string owner;
        
        public int Children { get; set; }
        
        public void GiveBirth() {
            
            Children = 2;
            
        }
        
        public Dog(string name) : base(name) {}

        public Dog(string name, string owner) : base(name) {

            this.owner = owner;
            Color = "ceva random";

        }

        public Dog(string name, string color, string owner) : base(name, color) {

            this.owner = owner;

        }

        public string GetOwner() {

            return owner;

        }

        public override void Sound() {
            
            base.Sound();
            Console.WriteLine("Bark!");
            
        }

    }

}