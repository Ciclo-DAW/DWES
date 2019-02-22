using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ejercicio.ViewComponents
{
    public class WordsViewComponent : ViewComponent
    {
        // Modificamos el componente para que reciba la lista de palabras como parámetro
        public async Task<IViewComponentResult> InvokeAsync(List<string> words) {
            return View(words);
        }
    }
}
