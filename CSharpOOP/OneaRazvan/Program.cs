using System;
 
public class AlbumFoto
{
    public static void Main()
    {
        PhotoAlbum myAlbum1 = new PhotoAlbum();
        Console.WriteLine(myAlbum1.GetNumberPages());
        
        PhotoAlbum myAlbum2 = new PhotoAlbum(32);
        Console.WriteLine(myAlbum2.GetNumberPages());

        BigPhotoAlbum myBigPhotoAlbum1 = new BigPhotoAlbum();
        Console.WriteLine(myBigPhotoAlbum1.GetNumberPages());
        myBigPhotoAlbum1.AddPage();
        Console.WriteLine(myBigPhotoAlbum1.GetNumberPages());
        myBigPhotoAlbum1.AddPhoto();
        myBigPhotoAlbum1.AddPhoto();
        myBigPhotoAlbum1.AddPhoto();
        myBigPhotoAlbum1.AddPhoto();
        Console.WriteLine(myBigPhotoAlbum1.GetNumberPages());
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
}