using Microsoft.AspNetCore.Mvc;
using Ejercicio.Models;

namespace Ejercicio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new HomeViewModel(""));
        }

        [HttpPost]
        public IActionResult Index(string text)
        {
            return View(new HomeViewModel(text));
        }
    }
}
