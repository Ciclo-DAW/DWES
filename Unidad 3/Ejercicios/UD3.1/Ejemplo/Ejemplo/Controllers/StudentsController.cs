using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejemplo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejemplo.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Student()
        {
            Student student = new Student
            {
                Id = 1,
                Nombre = "Juan Lucas",
                Apellidos = "Picardo"
            };

            ViewData["ciclo"] = "Desarrolo de aplicaciones web";
            ViewBag.Centro = "CIFP A Carballeira";

            return View(student);
        }
    }
}