using System;
using System.Collections.Generic;

namespace BregaStanislav {

    class PhotoAlbum {

        private int numberOfPages;

        public PhotoAlbum() {

            numberOfPages = 16;

        }

        public PhotoAlbum(int numberOfPages) {

            this.numberOfPages = numberOfPages;

        }

        public int GetNumberOfPages() {

            return numberOfPages;

        }

    }

    class BigPhotoAlbum {

        private int numberOfPages;
        private int numberOfPhotosOnPage = 0;

        public BigPhotoAlbum() {

            numberOfPages = 64;
            
        }
        
        public BigPhotoAlbum(int numberOfPages) {

            this.numberOfPages = numberOfPages;
            
        }
        
        public int GetNumberOfPages() {

            return numberOfPages;

        }

        private void AddPage() {

            numberOfPages++;

        }

        public void AddPhoto() {

            numberOfPhotosOnPage++;

            if (numberOfPhotosOnPage % 4 != 0) 
                return;

            AddPage();
            numberOfPhotosOnPage = 0;

        }

    }

    class Program {

        private static void Main() {

            const int numberOfAlbums = 7;
            var myAlbum = new List<PhotoAlbum>();
            var myBigAlbum = new List<BigPhotoAlbum>();

            var random = new Random();

            for (var i = 0; i < numberOfAlbums; ++i) {

                myAlbum.Add(new PhotoAlbum(random.Next(1, 17)));
                myBigAlbum.Add(new BigPhotoAlbum(random.Next(17, 65)));
                
            }

            for (var i = 0; i < numberOfAlbums; ++i)
                Console.Write("{0} ", myAlbum[i].GetNumberOfPages());
            
            Console.WriteLine();
            
            for (var i = 0; i < numberOfAlbums; ++i)
                Console.Write("{0} ", myBigAlbum[i].GetNumberOfPages());

            var minIndex = 0;

            for (var i = 0; i < numberOfAlbums; ++i)
                if (myBigAlbum[i].GetNumberOfPages() < myBigAlbum[minIndex].GetNumberOfPages())
                    minIndex = i;

            for (var i = 0; i < 4; ++i)
                myBigAlbum[minIndex].AddPhoto();
            
            Console.WriteLine();
            
            for (var i = 0; i < numberOfAlbums; ++i)
                Console.Write("{0} ", myAlbum[i].GetNumberOfPages());
            
            Console.WriteLine();
            
            for (var i = 0; i < numberOfAlbums; ++i)
                Console.Write("{0} ", myBigAlbum[i].GetNumberOfPages());

        }
        
    }
    
}