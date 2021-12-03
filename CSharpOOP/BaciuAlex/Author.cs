using System;
using System.Collections.Generic;

namespace BaciuAlex
{
    public class Author : Person
    {
        private Random rnd = new Random();
        private Publication publication;

        public int Counter { get; set; } = 0;

        public Publication GetPublication()
        {
            Work();
            return publication;
        }
        
        public override void Work()
        {
            this.publication = new Publication("Publicatie noua", this, rnd.Next(100));
            this.Counter += 1;
        }
    }
}