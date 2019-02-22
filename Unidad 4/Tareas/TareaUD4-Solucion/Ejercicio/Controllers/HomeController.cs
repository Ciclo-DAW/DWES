using Microsoft.AspNetCore.Mvc;
using Ejercicio.Models;

namespace Ejercicio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Candidato candidato)
        {
            // Primer paso de validación manual, requiriendo al menos un teléfono fijo o móvil
            if (string.IsNullOrEmpty(candidato.Movil) && string.IsNullOrEmpty(candidato.Telefono))
            {
                ModelState.AddModelError("Telefono", "Debe introducir un teléfono fijo o móvil.");
            }

            // Si la validación es correcta, añadimos la nueva palabra a la lista 
            if (ModelState.IsValid)
            {      
                return RedirectToAction("Detail", candidato);
            }

            return View(candidato);
        }

        public IActionResult Detail(Candidato candidato)
        {
            return View(candidato);
        }
    }
}
