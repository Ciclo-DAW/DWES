using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuguetylandiaWeb.Models
{
    public class Juguete
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Debe introducir el nombre del juguete")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "EAN")]
        public string Ean { get; set; }

        [Display(Name = "Referencia")]
        public string Referencia { get; set; }

        [Display(Name = "Marca")]
        public Marca Marca { get; set; }
        public int MarcaId { get; set; }

        [Display(Name = "PVP")]
        [RegularExpression("[0-9]*,*[0-9]{0,2}", ErrorMessage = "Debe introducir una cantidad válida")]
        public String PVP { get; set; }

        [Display(Name = "Oferta")]
        public int Oferta { get; set; }

        [Display(Name = "Descripción")]
        public String Descripcion { get; set; }

        [Display(Name = "Tipo de juguete")]
        [EnumDataType(typeof(Tipo))]
        public Tipo Tipo { get; set; }

        [Display(Name = "Edad")]
        [EnumDataType(typeof(Edad))]
        public Edad Edad { get; set; }

        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",
        ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de recepción")]
        public DateTime? FechaRecepcion { get; set; }

        [Display(Name = "Tienda")]
        public Tienda Tienda { get; set; }
        public int TiendaId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",
        ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de garantía")]
        public DateTime? FechaGarantia { get; set; }

        [Display(Name = "Información garantía")]
        public string InfoGarantia { get; set; }



    }
}