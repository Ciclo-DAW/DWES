using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ejercicio2.Models;

namespace Ejercicio2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int dni)
        {
            char[] arrayLetras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'};
            char letra = arrayLetras[dni % 23];
            ViewData["DNICompleto"] = String.Format("{0}{1}",dni, letra);
            return View();
        }

    }
}
