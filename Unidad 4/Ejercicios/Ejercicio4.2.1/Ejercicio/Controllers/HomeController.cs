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
        public IActionResult Index(string text)
        {
            // En este ejercicio no se muestra el resultado en la misma página que el formulario
            // Utilizamos una redirección a otra acción que se encarga de mostrar el mismo, 
            // y le pasamos los datos recogidos en nuestro formulario
            return RedirectToAction("Masked", new { Text = text });
        }

        public IActionResult Masked(string text)
        {   
            // Antes de mostrar la vista, nos aseguramos de que hemos recibido algún texto
            // Si no es así pasamos una cadena vacía como modelo a la vista para evitar un error de acceso a objeto nulo
            return View("Masked", text != null ? text : "");
        }
    }
}
