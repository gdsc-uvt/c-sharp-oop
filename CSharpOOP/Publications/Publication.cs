namespace BregaStanislav {

    public class Publication : Entity {

        public string Title { get; }

        public Author Author1 { get; }

        public int NumberOfPages { get; }

        public Publication(string Title, Author Author, int NumberOfPages) {

            this.Title = Title;
            this.Author1 = Author;
            this.NumberOfPages = NumberOfPages;

        }

    }

}