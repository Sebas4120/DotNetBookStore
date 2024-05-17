using Microsoft.AspNetCore.Mvc;

namespace DotNetBookStore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
