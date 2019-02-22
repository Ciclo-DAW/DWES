using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo1.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "Debe introducir el DNI")]
        [RegularExpression(pattern: "[0-9]{8}[A-Z]",
            ErrorMessage = "El DNI debe ser de la forma 11111111X")]
        public string Dni { get; set; }

        [Required(ErrorMessage = "Debe introducir el nombre")]
        public string Nombre { get; set; }
    }
}
