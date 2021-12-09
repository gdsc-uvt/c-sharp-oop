using System;
using System.Collections.Generic;

namespace NiculescuRobert
{
    abstract class  Entity
    {   
        public static Random rnd=new Random();
        public int Id=rnd.Next(0,250);
        public DateTime Created;
        public DateTime Modified;

        public Entity()
        {
            Created = DateTime.Now;
            Modified= DateTime.Now;
        }
        
        
    }

    class Person : Entity
    {
        private string Name { get; set; }
        private int Age;

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public string GetName()
        {
            return this.Name;
        }
        public virtual void Work()
        {
            Console.WriteLine("some random message from a person");
            
        }

        public virtual Publication Work(string title,int NumberPages)
        {
            return null;
        }
    }

    class Librarian : Person 
    {
        public Librarian(string name, int age) : base(name, age)
        {
            
        }
        
        public override void Work()
        {
            Console.WriteLine("Hello there!I see you are in some troubles with the books");
            Console.WriteLine("Our librarian is called {0},",this.GetName());
        }
        
    }

    class Author : Person
    {
        private List<string> lspublication=new List<string>();
        private int counter = 0;
        public Author(string name,int age): base(name,age)
        {
               
        }

        public override Publication Work(string title,int NumberPages)
        {
            counter += 1;
            return new Publication(title,this,NumberPages);
        }
    }

    class Publication : Entity
    {
        private string Title;
        private Author author;
        private int NumberOfPages;

        public Author Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public string title
        {
            get { return Title; }

            set { Title = value; }
            
        }
        
        public Publication(string title,Author author,int nrpages)
        {
            this.Title = title;
            this.author = author;
            this.NumberOfPages = nrpages;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Librarian favLibrarian = new Librarian("Rares", 53);
            Console.WriteLine(favLibrarian.Created);
            Librarian secondLibrarian = new Librarian("Andrei", 30);
            Librarian thirdLibrarian = new Librarian("Alex", 25);
            Author firstAuthor = new Author("Radu", 30);
            Author secondAuthor = new Author("Felix", 24);
            Author thirdAuthor = new Author("Alexia", 22);
            List<Author> lsAuthors = new List<Author>() {firstAuthor, secondAuthor, thirdAuthor};
            List<Publication> lsPubs = new List<Publication>();
            string s;
            Console.WriteLine("Authors work 3 times");
            Random rpages = new Random();
            foreach (var item in lsAuthors)
            {
                for (int i = 0; i < 3; ++i)
                {
                    s = Console.ReadLine();

                    lsPubs.Add(item.Work(s,  rpages.Next(0, 250)));

                }
            }
            Console.WriteLine();
            List<Entity> lsEntities = new List<Entity>();
            List<Librarian> lsLibrarians = new List<Librarian>() {favLibrarian, secondLibrarian, thirdLibrarian};
            lsEntities.AddRange(lsLibrarians);
            lsEntities.AddRange(lsAuthors);
            lsEntities.AddRange(lsPubs);
            Console.WriteLine();
            Console.WriteLine("Iterating over the big list of entities");
            Console.WriteLine(lsEntities);
            foreach (var item in lsEntities)
            {
                Console.WriteLine(item.Id);
                if (item is Librarian)
                { 
                    ((Librarian)item).Work();
                }

                if (item is Author)
                {
                    Console.WriteLine("We have an author : {0}, write his publication's title",((Author)item).GetName());
                    s = Console.ReadLine();
                    Console.WriteLine("This author has made something new : {0}",
                        ((Author) item).Work(s,rpages.Next(250, 950)).title);

                }

                if (item is Publication)
                {
                    Console.WriteLine("This is a publication");
                    Console.WriteLine(((Publication)item).title);
                    Console.WriteLine(((Publication)item).Author.GetName());
                    Console.WriteLine(((Publication)item).Created);
                }
                
            }

        }
    }
}
