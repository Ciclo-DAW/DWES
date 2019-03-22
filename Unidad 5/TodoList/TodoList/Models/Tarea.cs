using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class Tarea
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe introducir el texto de la descripción")]
        public string Descripcion { get; set; }

        public bool Realizada { get; set; }
    }
}
