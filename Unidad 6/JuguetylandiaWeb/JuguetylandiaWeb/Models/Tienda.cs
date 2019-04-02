using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuguetylandiaWeb.Models
{
    public class Tienda
    {
        public int ID { get; set; }
        [Display(Name = "Tienda")]
        [Required(ErrorMessage = "Debe introducir el código de la tienda")]
        public string Codigo { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        public List<Juguete> Juguetes { get; set; }
    }
}