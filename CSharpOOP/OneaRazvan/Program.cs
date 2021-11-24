using System;
using System.Collections.Generic;
using System.Linq;

public class AlbumFoto
{
    public static void Main()
    {
        PhotoAlbum myAlbum1 = new PhotoAlbum();
        PhotoAlbum myAlbum2 = new PhotoAlbum(24);
        PhotoAlbum myAlbum3 = new PhotoAlbum(32);

        List < PhotoAlbum > myPhotoAlbums = new List<PhotoAlbum>(2);
        myPhotoAlbums.Add(myAlbum1);
        myPhotoAlbums.Add(myAlbum2);
        myPhotoAlbums.Add(myAlbum3);

        BigPhotoAlbum myBigPhotoAlbum1 = new BigPhotoAlbum();
        BigPhotoAlbum myBigPhotoAlbum2 = new BigPhotoAlbum(69);
        BigPhotoAlbum myBigPhotoAlbum3 = new BigPhotoAlbum(2001);
        List < BigPhotoAlbum > myBigPhotoAlbums = new List<BigPhotoAlbum>(2);
        myBigPhotoAlbums.Add(myBigPhotoAlbum1);
        myBigPhotoAlbums.Add(myBigPhotoAlbum2);
        myBigPhotoAlbums.Add(myBigPhotoAlbum3);
        
        
        
        foreach (var i in myPhotoAlbums)
        {
            
            Console.WriteLine("The number of pages is "+i.GetNumberPages());            
        }
        
        Console.WriteLine("\n");
        
        int lessPages = myBigPhotoAlbums.Min(z => z.GetNumberPages());
        foreach (var x in myBigPhotoAlbums)
        {
            Console.WriteLine("The number of pages is "+x.GetNumberPages());
            if (x.GetNumberPages()==lessPages)
            {
                x.AddPhoto();
                x.AddPhoto();
                x.AddPhoto();
                x.AddPhoto();
            }
        }
        Console.WriteLine("\n");
        foreach (var x in myBigPhotoAlbums)
        {
            Console.WriteLine("The number of pages is "+x.GetNumberPages());
        }

        
        myBigPhotoAlbum1.AddPage();
        Console.WriteLine(myBigPhotoAlbum1.GetNumberPages()); // afisarea numarului de pagini dupa adaugarea unei pagini
        
        myBigPhotoAlbum1.AddPhoto();
        myBigPhotoAlbum1.AddPhoto();
        myBigPhotoAlbum1.AddPhoto();
        myBigPhotoAlbum1.AddPhoto();
        Console.WriteLine(myBigPhotoAlbum1.GetNumberPages()); // afisarea numarului de pagini dupa adaugarea a 4 poze
        
    }
}
 
public class PhotoAlbum
{
    private int numPages;
    
    public PhotoAlbum()
    {
        numPages = 16;
    }
 
    public PhotoAlbum(int numPages)
    {
        this.numPages = numPages;
    }
 
    public int GetNumberPages()
    {
        return numPages;
    }
}
 
public class BigPhotoAlbum
{   private int photo = 1; 
    private int numPages;
    public BigPhotoAlbum()
    {
        numPages = 64;
    }

    public int AddPage()
    {
        return numPages++;
    }

    public int AddPhoto()
    {
        if (photo % 4 == 0)
        {
            AddPage();
        }
        else photo++;
        return numPages;
    }
    public int GetNumberPages()
    {
        return numPages;
    }
    public BigPhotoAlbum(int numPages)
    {
        this.numPages = numPages;
    }
}