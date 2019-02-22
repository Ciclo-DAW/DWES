using Microsoft.AspNetCore.Mvc;
using Ejercicio.Models;
using System;

namespace Ejercicio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Dni dni)
        {
            // En este ejercicio utilizamos validación automática, el método comprueba que se cumplen
            // los requerimientos del modelo, en caso contrario volvemos a abrir el formulario,
            // que mostrará los errores de validación que se han encontrado
            if(!ModelState.IsValid)
            {
                return View(dni);
            }

            return RedirectToAction("DniCompleto", dni);
        }

        public IActionResult DniCompleto(Dni dni)
        {   
            // Antes de mostrar la vista, nos aseguramos de que hemos recibido algún texto
            // Si no es así pasamos una cadena vacía como modelo a la vista para evitar un error de acceso a objeto nulo
            return View(dni);
        }
    }
}
