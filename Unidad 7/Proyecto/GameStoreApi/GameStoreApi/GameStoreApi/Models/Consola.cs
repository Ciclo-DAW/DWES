using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreApi.Models
{
    public class Consola
    {
        public int ID { get; set; }

        [Display(Name = "Marca")]
        public Marca Marca { get; set; }
        public int MarcaId { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Debe introducir el modelo de consola")]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Cantidad (Opcional)")]
        public int? Cantidad { get; set; }

        [Range(0, 9999.99)]
        [Display(Name = "Precio (€)")]
        public float Precio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de la oferta")]
        public DateTime? FechaSalida { get; set; }

        [Display(Name = "Estado de la consola")]
        [EnumDataType(typeof(Estados))]
        public Estados Estado { get; set; }

        [Display(Name = "Tienda")]
        public Tienda Tienda { get; set; }
        public int TiendaId { get; set; }
    }
}
