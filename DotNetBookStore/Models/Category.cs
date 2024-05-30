namespace DotNetBookStore.Models
{
    public class Category
    {
        //Primary key fields should always be called either {Model}Id or just Id
        public int CategoryId { get; set; }

        public string Name { get; set; }
    }
}
