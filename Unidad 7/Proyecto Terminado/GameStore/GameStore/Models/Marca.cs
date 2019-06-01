using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Models
{
    public class Marca
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Debe introducir el nombre de la marca")]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        public List<Periferico> Perifericos { get; set; }
        public List<Consola> Consolas { get; set; }
    }
}
