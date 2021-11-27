using System;

namespace DanPercic
{
    public class Entity
    {
        public string Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }

    interface IAlias
    {
        string Alias { get; set; }
    }

    public class Article : Entity, IAlias
    {
        public string Alias { get; set; }
    }

    public class News : Entity, IAlias
    {
        public string Alias { get; set; }
    }

    public class Event : Entity
    {
    }
}
