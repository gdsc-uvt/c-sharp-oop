// See https://aka.ms/new-console-template for more information
using System;

namespace BaciuAlex
{
    class Animal
    {
        private string name;
        public string color;

        public Animal(string name)
        {
            this.name = name;
            this.color = "black";
        }
        
        public Animal(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public string GetName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Animal: " + name + " " + color;
        }
        
        ~Animal()
        {
            Console.WriteLine("Destructor");
        }
    }

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
        static void Main(string[] args)
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
    }
    
    
}
