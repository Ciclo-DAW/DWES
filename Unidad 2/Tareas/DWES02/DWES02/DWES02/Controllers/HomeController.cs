using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DWES02.Models;

namespace DWES02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Baraja baraja1 = new Baraja();
            baraja1.Barajar();

            //Chapuza?
            //string[] arrayDeCartas = new string[40];
            //for (int i = 0; i < baraja1.cartas.Length; i++)
            //{
            //    arrayDeCartas[i] = baraja1.cartas[i].palo.ToString() + "-" + baraja1.cartas[i].numero.ToString();
            //}

            ViewData["baraja"] = baraja1.cartas;
            return View();
        }

    } 
}
