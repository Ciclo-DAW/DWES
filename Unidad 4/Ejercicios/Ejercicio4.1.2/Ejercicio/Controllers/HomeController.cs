using Microsoft.AspNetCore.Mvc;
using Ejercicio.Models;
using System;

namespace Ejercicio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(DateTime date)
        {
            return View(new Tarot(date));
        }
    }
}
