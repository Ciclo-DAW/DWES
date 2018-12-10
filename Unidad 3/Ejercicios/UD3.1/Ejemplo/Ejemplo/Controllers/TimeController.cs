using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ejemplo.Controllers
{
    public class TimeController : Controller
    {
        [ResponseCache(Duration = 600)]
        public IActionResult Index()
        {
            return Content(DateTime.Now.ToLongTimeString());
        }
    }
}