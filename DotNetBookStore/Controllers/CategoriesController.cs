using Microsoft.AspNetCore.Mvc;

namespace DotNetBookStore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Browse(string category)
        {
            ViewBag.Category = category; //ViewBag is a dynamic object, methd that send data from CONTROLLER Action Method to View
            return View();
        }
    }
}
