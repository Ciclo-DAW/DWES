using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ejemplo.Controllers
{
    public class HomeController : Controller
    {
        [NotOnSundaysFilter]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return new UpperStringActionResult("Hola desde nuestro primer controlador INDEX2");
        }
    }
}