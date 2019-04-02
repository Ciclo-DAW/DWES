using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Libros.Models
{
    public class Autor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe introducir el nombre del autor")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe introducir los apellidos del autor")]
        public string Apellidos { get; set; }

        public string NombreCompleto
        {
            get { return Nombre + " " + Apellidos; }
        }

    }
}
