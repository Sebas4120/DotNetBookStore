using DotNetBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotNetBookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Action Methods 1
        // Para que el programa capture la View que deseas, en
        // la carpeta view debes tener un View con el mismo nombre.
        public IActionResult Index()
        {
            return View();
        }

        //Action Methods 2
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
