using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TareaUD4.Models
{
    public class Informacion
    {
        [Required(ErrorMessage = "Debe introducir el nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe introducir los apellidos")]
        public string Apellidos { get; set; }

        public string Telefono { get; set; }
        //[RegularExpression(pattern: "[0-9]{9}",
        //   ErrorMessage = "El móvil deben ser nueve números")]
        public string Movil { get; set; }

        public string Estudios { get; set; }

        public string[] Idioma { get; set; }

        public string Vehiculo { get; set; }

        public string Observaciones { get; set; }

        [DataType((DataType.Date),
        ErrorMessage = "Debe introducir una fecha válida")]
        public DateTime Fecha { get; set; }

    }
}
