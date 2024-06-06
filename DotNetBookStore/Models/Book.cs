using System.ComponentModel.DataAnnotations;

namespace DotNetBookStore.Models
{
    public class Book
        
    {
        [Required]
        [MaxLengthAttribute(100)]
        //thi is the Primary Key
        //Primary key fields should always be called either {Model name} + Id or just Id
        public int BookId {  get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Title { get; set; }

        

        // We add '?' to make a variable nullable... para que Image = null
        public string? Image {  get; set; }

        public decimal Price { get; set; }

        public bool MaturedContent { get; set; }

        // Now I need to add a "FOREIGN KEY"

        public int CategoryId {  get; set; }
    }
}
