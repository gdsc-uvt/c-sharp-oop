using System;

namespace BregaStanislav {

    public class Librarian : Person {

        public Librarian(string Name, int Age) : base(Name, Age) {}
        
        public override Publication Work(string Title) {
            
            Console.WriteLine("Salut! Numele meu este {0}", Name);

            return null;

        }

    }

}