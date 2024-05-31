namespace DotNetBookStore.Models
{
    public class Book
    {
        //Primary Key
        public int BookId {  get; set; }

        public string Author { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        // We add '?' to make a variable nullable
        public string? Image {  get; set; }

        public bool MaturedContent
    }
}
