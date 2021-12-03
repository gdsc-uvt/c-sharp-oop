using System;
using System.Collections.Generic;

namespace BregaStanislav {
    
    class Program {

        private static void Main() {

            var librarian1 = new Librarian("Andrzej", 56);
            var librarian2 = new Librarian("Sapkowski", 81);
            var librarian3 = new Librarian("Chalotra", 45);
            
            var author1 = new Author("Coelho", 74);
            var author2 = new Author("Rowling", 56);
            var author3 = new Author("Sapkowski", 73);

            var publications = new List<Publication> {
                
                author1.Work("The Alchemist"),
                author1.Work("Eleven Minutes"),
                author1.Work("The Pilgrimage"),
                author2.Work("Harry Potter"),
                author2.Work("The Ickabog"),
                author2.Work("The Christmas Pig"),
                author3.Work("The Last Wish"),
                author3.Work("Blood of Elves"),
                author3.Work("Sword of Destiny")
                
            };

            var entities = new List<Entity>() {

                librarian1, librarian2, librarian3,
                author1, author2, author3

            };
            
            entities.AddRange(publications);

            foreach (var entity in entities) {

                Console.WriteLine("Id: {0}", entity.Id);

                if (entity is Librarian usualLibrarian)
                    usualLibrarian.Work("New work");
                else if (entity is Author usualAuthor)
                    usualAuthor.Work("New work");
                else if (entity is Publication usualPublication)
                    Console.WriteLine("Lucrarea '{0}' are autorul {1} si a fost scrisa {2}", usualPublication.Title, usualPublication.Author1.Name, usualPublication.Created);
                
            }

        }
        
    }
    
}