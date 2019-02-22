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
        public IActionResult Index(string temperature, char conv)
        {
            // Este ejemplo utiliza un mecanismo de validación manual, para ilustrar su funcionamiento
            // Intentamos convertir la cadena de entrada a un número decimal, si no se puede,
            // añadimos un mensaje de error y volvemos al formulario
            decimal temp;
            try
            {
                temp = decimal.Parse(temperature);
            }
            catch(Exception)
            {
                ModelState.AddModelError("Temperature", "La temperatura introducida no es correcta");
                return View();
            }

            var converter = new TemperatureConverter();
            if (conv == 'c')
            {
                converter.Celsius = temp;
            }
            else
            {
                converter.Fahrenheit = temp;
            }

            return View(converter);
        }
    }
}
