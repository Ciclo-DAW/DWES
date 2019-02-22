using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejemplo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejemplo1.Controllers
{
    public class CensoController : Controller
    {
        public IActionResult Comprobar()
        {
            return View();
        }

        //[ActionName("Comprobar")] //Indicamos que queremos que el nombre del metodo de accion sea comprobar
        [HttpPost] //Indicamos que queremos que este método se use para las peticiones post
        //public IActionResult ComprobarPost()
        public IActionResult Comprobar(Persona persona)
        {
            //var nombre = this.HttpContext.Request.Form["name"];
            //var dni = this.HttpContext.Request.Form["dni"];
            //return Content($"Nombre: {persona.Nombre}, DNI: {persona.Dni}");
            //return View("Informacion", persona);
            if (ModelState.IsValid)
            {
                return RedirectToAction("informacion", persona);
            }
            return View(persona);
        }

        public ActionResult Informacion(Persona p)
        {
            return View(p);
        }
    }
}