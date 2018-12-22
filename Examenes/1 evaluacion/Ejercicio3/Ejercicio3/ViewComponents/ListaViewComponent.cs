using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio3.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio3.ViewComponents
{
    public class ListaViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() {
            {
                return View(HomeController.listaPalabras);
            }
        }
    }
}
