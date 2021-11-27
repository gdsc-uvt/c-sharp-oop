using System;

namespace BregaStanislav {

    public class Cat : Animal, IMammal {
        
        public bool IsCastrated { get; private set; }
        
        public int Children { get; set; }

        public void GiveBirth() {
            
            Children = 5;
            
        }

        public Cat() : base() {

            IsCastrated = false;
            Console.WriteLine(IsCastrated);
            
        }

        public Cat(string name) : base(name) {
            
            Console.WriteLine("new [Cat] with name");
            
        }

        public Cat(string name, string color) : base(name, color) {
            
            Console.WriteLine("new [Cat] with name and color");
            
        }

        public override void Sound() {
            
            base.Sound();
            Console.WriteLine("Miew");
            
        }

    }

}