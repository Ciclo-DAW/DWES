using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuguetylandiaWeb.Models
{
    public class Marca
    {
        public int ID { get; set; }
        [Display(Name = "Marca")]
        [Required(ErrorMessage = "Se debe introducir el nombre de la marca")]
        public string Nombre { get; set; }
        public List<Juguete> Juguetes { get; set; }
    }
}