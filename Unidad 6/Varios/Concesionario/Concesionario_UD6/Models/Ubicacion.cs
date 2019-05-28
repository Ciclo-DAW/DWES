using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Concesionario_UD6.Models
{
    public class Ubicacion
    {
        public int ID { get; set; }
        [Display(Name = "Localización")]
        [Required(ErrorMessage = "Débese engadir o nome da localización")]
        public string Nome { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }
    }
}
