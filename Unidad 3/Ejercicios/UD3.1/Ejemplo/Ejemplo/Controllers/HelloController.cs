using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ejemplo.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Greeting()
        {
            return new UpperStringActionResult("Hola desde HelloController - Greeting");
        }
        public IActionResult Greeting2()
        {
            return new UpperStringActionResult("Hola desde HelloController - Greeting2");
        }
        public IActionResult Greeting3(int id)
        {
            return new UpperStringActionResult("Hola desde HelloController - Greeting2 - El id es " + id);
        }
    }
}