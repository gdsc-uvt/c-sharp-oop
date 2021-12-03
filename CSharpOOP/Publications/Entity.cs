using System;

namespace BregaStanislav {

    public abstract class Entity {

        public string Id { get; }

        public DateTime Created { get; }

        public DateTime Modified { get; }

        protected Random random = new Random();

        protected Entity() {

            Id = random.Next().ToString();
            Created = DateTime.Now;
            Modified = DateTime.Now;

        }

    }

}