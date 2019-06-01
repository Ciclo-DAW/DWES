using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Models
{
    public class Juego
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Debe introducir el nombre del juego")]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe introducir el modelo de consola del juego")]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Modelo de consola")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Debe introducir una descripción del juego")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Cantidad (Opcional)")]
        public int? Cantidad { get; set; }

        [Required(ErrorMessage = "Debe introducir un precio")]
        [Range(0, 9999.99, ErrorMessage = "El precio no puede superar 9999.99")]
        [Display(Name = "Precio (€)")]
        public float Precio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de la oferta")]
        public DateTime? FechaSalida { get; set; }

        [Display(Name = "Estado del juego")]
        [EnumDataType(typeof(Estados))]
        public Estados Estado { get; set; }

        [Display(Name = "Género del juego")]
        [EnumDataType(typeof(GenerosJuego))]
        public GenerosJuego Genero { get; set; }

        [Display(Name = "Tienda")]
        public Tienda Tienda { get; set; }
        public int TiendaId { get; set; }
    }
}
