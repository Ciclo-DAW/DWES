using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ejercicio_2._3._4.Models;

namespace Ejercicio_2._3._4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int number)
        {
            ViewData["n"] = number;
            return View();
        }

        public static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
