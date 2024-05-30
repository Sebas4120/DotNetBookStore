using DotNetBookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetBookStore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {   
            //paso 1: Aca creamos los datos en el Model

            //Use the Category Model to generate 10 categories in memory to display in the view
            //List list contains Model Category objects
            var categories = new List<Category>();
            //adding categories objects to this list
            for (int i =1; i<11; i++)
            {
                categories.Add(new Category { CategoryId = i, Name = "Category " + i.ToString() });
            }

            //Paso 2: Ahora toca pasarle estos datos del Model a View
            //must now pass the strongly-types data to the view 
                //Aqui lo que estoy haciendo es pasar mi lista de categories que he creado a mi View
            return View(categories);
        }

        public IActionResult Browse(string category)
        {   
            //This is the process to passing the value to my View
            ViewBag.Category = category; //ViewBag is a dynamic object, methd that send data from CONTROLLER Action Method to View
            return View();
        }
    }
}
