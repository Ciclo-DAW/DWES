using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class HomeController : Controller
    {
        public static int counter = 0;

        public IActionResult Index()
        {
            
            int a = 10;
            int b = 7;
            counter++;

            ViewData["suma"] = $"{a} + {b} = {a + b}";
            ViewData["resta"] = $"{a} - {b} = {a - b}";
            ViewData["prod"] = $"{a} * {b} = {a * b}";
            ViewData["div"] = $"{a} / {b} = {(double)a / b}";
            ViewData["counter"] = $"Esta página se ha mostrado {counter} veces";

            return View();
        }

    }
}
