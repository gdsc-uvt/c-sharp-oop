namespace BaciuAlex
{
    public class Publication : Entity
    {
        public string Title { get; }
        public Author Author { get; }
        public int NumberOfPages { get; }

        public Publication(string Title, Author Author, int NumberOfPages)
        {
            this.Title = Title;
            this.Author = Author;
            this.NumberOfPages = NumberOfPages;
        }
    }
}