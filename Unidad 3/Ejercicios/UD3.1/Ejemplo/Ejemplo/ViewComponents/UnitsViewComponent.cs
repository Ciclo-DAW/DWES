using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo.ViewComponents
{
    public class UnitsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var units = new List<string> {
                "UD 1. Plataformas de programación web en entorno servidor.",
                "UD 2. ASP.NET Core. Características. El lenguaje C#.",
                "UD 3. ASP.NET Core MVC.",
                "UD 4. Formularios y enlace de datos.",
                "UD 5. Acceso a datos con ASP.NET Core. ",
                "UD 6. Desarrollo de aplicaciones web con ASP.NET Core.",
                "UD 7. Servicios web.",
                "UD 8. Aplicaciones web dinámicas. SPA´s.",
                "UD 9. Aplicaciones web híbridas."
                };
            return View(units);
        }
    }
}
