using System;

namespace BaciuAlex
{
    public class Librarian : Person
    {
        public override void Work()
        {
            this.Name = "Alex";
            
            Console.WriteLine("Salut, numele meu este " + this.Name);
        }
    }
}