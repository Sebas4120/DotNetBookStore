using System.ComponentModel.DataAnnotations;

namespace DotNetBookStore.Models
{
    public class Category
    {
        //Primary key fields should always be called either {Model}Id or just Id
        // The display name of CATEGORYID en Views se puede cambiar con DATA ANNOTATIONS

        //La DATA ANNOTATIONS se coloca encima del dato que quieres editar, en este caso, CategoryId es lo que queremos editar.
        //[Display(Name = "Category ID")]

        //Para crear DATA VALIDATION is in our MODEL!!!!
        //[Range(1,999999)]

        public int CategoryId { get; set; } // This is a primary key
        [Required(ErrorMessage ="A customized error message")]
        public string Name { get; set; }

        //child reference to Books (1 category / many books)
            //For child and parent reference we have to use '?'
        public List<Book>? Books { get; set; }
    }
}
