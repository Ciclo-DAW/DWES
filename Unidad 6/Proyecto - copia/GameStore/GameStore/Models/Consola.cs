using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Models
{
    public class Consola
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Debe introducir la marca de la consola")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Debe introducir el modelo de consola")]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Range(0, 9999.99)]
        [Display(Name = "Precio en euros")]
        public float Precio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de salida")]
        public DateTime? FechaSalida { get; set; }

        [Display(Name = "Estado de la consola")]
        [EnumDataType(typeof(Estados))]
        public Estados Estado { get; set; }

        public List<Juego> Juegos { get; set; }
        public List<Periferico> Perifericos { get; set; }
    }
}
