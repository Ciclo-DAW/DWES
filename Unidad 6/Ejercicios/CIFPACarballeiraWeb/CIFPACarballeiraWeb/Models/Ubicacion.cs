using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIFPACarballeiraWeb.Models
{
    public class Ubicacion
    {
        public int ID { get; set; }
        [Display(Name = "Ubicación")]
        [Required(ErrorMessage = "Debe introducir el nombre de la ubicación")]
        public string Nombre { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public List<Material> Materiales { get; set; }
    }
}
