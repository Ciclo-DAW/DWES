using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ejercicio_2._3._2.Models;

namespace Ejercicio_2._3._2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int day, int month, int year)
        {
            ViewData["day"] = day;
            ViewData["month"] = month;
            ViewData["year"] = year;
            ViewData["tarot"] = CalcularTarot(day, month, year);
            return View();
        }

        private int CalcularTarot(int d, int m, int y)
        {
            int tarot = SumOfDigits(d) + SumOfDigits(m) + SumOfDigits(y);

            while (tarot > 9)
            {
                tarot = SumOfDigits(tarot);
            }

            return tarot;
        }

        private int SumOfDigits(int number) //Este método suma las unidades de un número
        {
            int result = number % 10; //Cogemos el resto, por ejemplo 1990 % 10 = 0
            int n = number / 10; //Cogemos las unidades, por ejemplo 1990 / 10 = 199

            while(n > 0)
            {
                result += n % 10; //result = 0 + 9
                n /= 10; //n = 19
            }

            return result;
        }
       
    }
}
