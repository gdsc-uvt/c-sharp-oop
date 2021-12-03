using System;

namespace BaciuAlex
{
    public class Entity
    {
        public string Id { get;  }
        public DateTime Created { get;  }
        public DateTime Modified { get; }

        public Entity()
        {
            Random rnd = new Random();
            Id = rnd.Next(1000).ToString();
            
            Created = DateTime.Now;
            Modified = DateTime.Now;
        }
    }
}