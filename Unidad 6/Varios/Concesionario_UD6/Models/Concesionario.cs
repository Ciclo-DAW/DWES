using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Concesionario_UD6.Models
{
    public class Concesionario
    {
        public int ID { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Débese engadir o nome dun Concesionario")]
        public string Nome { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }
    }
}
