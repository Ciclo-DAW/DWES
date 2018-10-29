using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ejercicio_2._3._3.Models;

namespace Ejercicio_2._3._3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int number)
        {
            ViewData["factorial"] = Factorial(number);
            ViewData["n"] = number;
            return View();
        }

        private long Factorial(long number)
        {
            if(number <= 1)
            {
                return 1;
            } else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
