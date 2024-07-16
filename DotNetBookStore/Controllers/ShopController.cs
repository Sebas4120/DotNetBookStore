using DotNetBookStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace DotNetBookStore.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var categories = _context.Categories.OrderBy(c ==> c.Name).toList();
            return View();
        }
    }
}
