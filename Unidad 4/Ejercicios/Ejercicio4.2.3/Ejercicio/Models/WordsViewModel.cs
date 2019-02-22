using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio.Models
{
    // Esta clase será el modelo de datos para la vista, conteniendo tanto la palabra que se añade,
    // permitiendo especificar los requisitos para la validación, como la lista de palabras
    public class WordsViewModel
    {
        [Required(ErrorMessage = "Debe introducir una palabra")]
        [RegularExpression(pattern: "[A-Za-zÁÉÍÓÚáéíóú]+",
            ErrorMessage = "Debe introducir únicamente una palabra")]
        public string Word { get; set; }

        public Words Words { get; set; }

        public WordsViewModel()
        {
            Word = "";
            Words = new Words();
        }
    }
}
