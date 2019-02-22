using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TareaUD4.Models;

namespace TareaUD4.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Comprobar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Comprobar(Informacion informacion)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Resultado", informacion);
            }
            return View(informacion);
        }

        public ActionResult Resultado(Informacion i)
        {
            return View(i);
        }
    }
}