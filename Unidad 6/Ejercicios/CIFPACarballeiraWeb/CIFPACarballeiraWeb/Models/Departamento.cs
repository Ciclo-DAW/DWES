using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIFPACarballeiraWeb.Models
{
    public class Departamento
    {
        public int ID { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Se debe introducir el nombre del departamento")]
        public string Nombre { get; set; }
        public List<Material> Materiales { get; set; }
    }
}
