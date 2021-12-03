// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace BaciuAlex
{
    class PhotoAlbum
    {
        private int numberOfPages;

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public PhotoAlbum(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }

    class BigPhotoAlbum
    {
        private float numberOfPages = 64;

        public void AddPage()
        {
            numberOfPages++;
        }

        public void AddPhoto()
        {
            numberOfPages += 0.25f;
        }

        public float GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
    
    class Program
    {
        static void Photo()
        {
            PhotoAlbum photo1 = new PhotoAlbum(10);
            PhotoAlbum photo2 = new PhotoAlbum(20);
            PhotoAlbum photo3 = new PhotoAlbum(30);
            PhotoAlbum photo4 = new PhotoAlbum(40);
            
            PhotoAlbum[] photos = { photo1, photo2, photo3, photo4 };
            
            BigPhotoAlbum bigphoto1 = new BigPhotoAlbum();
            BigPhotoAlbum bigphoto2 = new BigPhotoAlbum();

            BigPhotoAlbum bigphoto3 = new BigPhotoAlbum();
            BigPhotoAlbum bigphoto4 = new BigPhotoAlbum();
            
            // are cele mai putine pagini, asa ca ii adaug 4 poze
            bigphoto1.AddPhoto();
            bigphoto1.AddPhoto();
            bigphoto1.AddPhoto();
            bigphoto1.AddPhoto();
            
            bigphoto2.AddPage();
            
            bigphoto3.AddPage();
            bigphoto3.AddPage();
            
            bigphoto4.AddPage();
            bigphoto4.AddPage();
            bigphoto4.AddPage();

            BigPhotoAlbum[] bigPhotos = { bigphoto1, bigphoto2, bigphoto3, bigphoto4 };

            Console.WriteLine("Albume de tip PhotoAlbum:");
            foreach (var photo in photos)
            {
                Console.WriteLine("Albumul are " + photo.GetNumberOfPages() + " pagini");
            }
    
            Console.WriteLine();
            Console.WriteLine("Albume de tip BigPhotoAlbum:");
            foreach (var photo in bigPhotos)
            {
                Console.WriteLine("Albumul are " + photo.GetNumberOfPages() + " pagini");
            }
        }

        static public void Tema2()
        {
            Librarian librarian1 = new Librarian();
            Librarian librarian2 = new Librarian();
            Librarian librarian3 = new Librarian();
            
            Author author1 = new Author();
            Author author2 = new Author();
            Author author3 = new Author();

            var publications = new List<Publication>();
            
            publications.Add(author1.GetPublication());
            publications.Add(author1.GetPublication());
            publications.Add(author1.GetPublication());
            
            publications.Add(author2.GetPublication());
            publications.Add(author2.GetPublication());
            publications.Add(author2.GetPublication());
            
            publications.Add(author3.GetPublication());
            publications.Add(author3.GetPublication());
            publications.Add(author3.GetPublication());

            var entities = new List<Entity>()
            {
                librarian1, librarian2, librarian3,
                author1, author2, author3,
            };
            
            entities.AddRange(publications);

            foreach (var entity in entities)
            {
                Console.WriteLine("Id: " + entity.Id);

                if (entity is Librarian)
                {
                    var entity2 = entity as Librarian;
                    entity2.Work();
                    Console.WriteLine();
                }
                
                if (entity is Author)
                {
                    var entity2 = entity as Author;
                    entity2.Work();
                    Console.WriteLine();
                }

                if (entity is Publication)
                {
                    var entity2 = entity as Publication;
                    Console.WriteLine("Titlul publicatiei: " + entity2.Title);
                    Console.WriteLine("Autorul publicatiei: " + entity2.Author.Name);
                    Console.WriteLine("Data crearii publicatiei: " + entity2.Created);
                    Console.WriteLine();
                }
                    
            }
        }

        static void Main(string[] args)
        {
            var cat = new Cat("Pisica");
            var cat2 = new Cat("Pisica", "alba");
            
            cat.AnimalSound();

            var dog = new Dog("Sasha", "White", "Eu");
            dog.AnimalSound();
            dog.GetName();

            var unknownAnimal = new Animal("Unknown");
            var dogAsAnimal = dog as Animal;

            var animals = new List<Animal> {unknownAnimal, dogAsAnimal, cat, new Animal {Alias = "ceva"}};

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetName());
                animal.AnimalSound();

                if (animal is Dog)
                {
                    Console.WriteLine("Caine");
                    Console.WriteLine(((Dog)animal).owner);
                    Console.WriteLine(animal.ToString());
                }
                else if(animal is Cat usualCat)
                {
                    Console.WriteLine("Pisica");
                }
                else
                {
                    Console.WriteLine("Unknown animal!");
                }
            }
            
            var mamals = new List<IMamal> { dog, cat };
            
            foreach (var mamal in mamals)
            {
                mamal.GiveBirth();
                Console.WriteLine(mamal.Children);
            }
            
            Console.WriteLine(dog.Children);
            Console.WriteLine(cat.Children);

            Tema2();
        }
    }

}
