using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ejercicio3.Models;

namespace Ejercicio3.Controllers
{
    public class HomeController : Controller
    {
        public static List<String> listaPalabras = new List<String>();
        public List<String> ListaPalabras { get { return listaPalabras; } }
        public IActionResult Index(string palabra)
        {
            if (!String.IsNullOrEmpty(palabra) && !listaPalabras.Contains(palabra)) { listaPalabras.Add(palabra); };
            List<String> tmp = new List<String>(listaPalabras);
            tmp.Sort();
            //return View(listaPalabras); //Esto era antes de ordenarla
            return View(tmp);
        }
    }
}
