using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ejercicio_2._3._1.Models;

namespace Ejercicio_2._3._1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(double cent)
        {
            ViewData["dg"] = cent;
            ViewData["fh"] = Fahrenheit(cent);
            return View();
        }

        private double Fahrenheit(double cent)
        {
            return cent * 9 / 5 + 32;
        }
    }
}
