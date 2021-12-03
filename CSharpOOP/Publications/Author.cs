using System;

namespace BregaStanislav {

    public class Author : Person {

        public int NumberOfPublications { get; set; }

        public Author(string Name, int Age) : base(Name, Age) {

            NumberOfPublications = 0;

        }
        
        public override Publication Work(string Title) {

            NumberOfPublications += 1;
            
            return new Publication(Title, this, random.Next(1000));

        }

    }

}