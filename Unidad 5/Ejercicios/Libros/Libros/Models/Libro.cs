using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Libros.Models
{
    public class Libro
    {       
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe introducir el título del libro")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Debe introducir el ISBN del libro")]
        public string ISBN { get; set; }

        public DateTime FechaPublicacion { get; set; }

        public int AutorId { get; set; } //Clave foránea que relaciona libro con autor (Entidad + Id)
        public Autor Autor { get; set; } //Propiedad de navegación, permite acceder a una entidad desde una entidad asociada
    }
}
