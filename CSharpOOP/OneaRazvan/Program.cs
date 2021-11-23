using System;
 
public class AlbumFoto
{
    public static void Main()
    {
        PhotoAlbum myAlbum1 = new PhotoAlbum();
        Console.WriteLine(myAlbum1.GetNumberPages());

        BigPhotoAlbum myBigPhotoAlbum1 = new BigPhotoAlbum();
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
{
    private int numPages;
    public BigPhotoAlbum()
    {
        numPages = 64;
    }
    public int GetNumberPages()
    {
        return numPages;
    }
}