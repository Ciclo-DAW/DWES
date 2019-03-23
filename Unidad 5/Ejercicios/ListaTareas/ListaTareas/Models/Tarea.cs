using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListaTareas.Models
{
    public class Tarea
    {
        [Required(ErrorMessage = "Debe introducir el texto de la descripción")]
        public string Descripcion { get; set; }
        public int Id { get; set; }
        public bool Realizada { get; set; }
    }
}
