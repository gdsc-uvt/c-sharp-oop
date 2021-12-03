using System;
using System.Security.Cryptography;

namespace BregaStanislav {

    public class Person : Entity {

        public string Name { get; }
        public int Age { get; }

        protected Person(string Name, int Age) {

            this.Name = Name;
            this.Age = Age;

        }

        public virtual Publication Work(string Title) {
            
            Console.WriteLine("Mesaj Random");

            return null;

        }

    }

}