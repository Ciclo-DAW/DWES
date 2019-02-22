using Microsoft.AspNetCore.Mvc;
using Ejercicio.Models;

namespace Ejercicio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new WordsViewModel() { });
        }

        [HttpPost]
        public IActionResult Index(WordsViewModel wvm)
        {
            // Si la validación es correcta, añadimos la nueva palabra a la lista 
            if(ModelState.IsValid)
            {
                wvm.Words.AddWord(wvm.Word);
                wvm.Word = "";
            }

            return View(wvm);
        }
    }
}
