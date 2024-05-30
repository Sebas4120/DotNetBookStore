namespace DotNetBookStore.Models
{
    public class Category
    {
        //Primary key fields should always be called either {Model}Id or just Id
        public int CategoryId { get; set; } // This is a primary key

        public string Name { get; set; }
    }
}
