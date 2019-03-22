using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIFPACarballeiraWeb.Models
{
    [Table("Materiales")]
    public class Material
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Debe introducir el nombre del material inventariable")]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Debe introducir el nombre del material inventariable")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Número de serie")]
        public string NumSerie { get; set; }

        [Display(Name = "Tipo de material")]
        [EnumDataType(typeof(TiposMaterial))]
        public TiposMaterial TipoMaterial { get; set; }

        [Display (Name ="Descripción")]
        public String Descripcion { get; set; }

        [Required(ErrorMessage = "Debe introducir la cantidad")]
        [Display (Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Display (Name="Proveedor")]
        public String Proveedor { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de recepción")]
        public DateTime? FechaRecepcion { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de garantía")]
        public DateTime? FechaGarantia { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de retirada")]
        public DateTime? FechaRetirada { get; set; }

        [Display(Name ="Contacto en garantía")]
        public string InfoGarantia { get; set; }

        [Display(Name = "Situación de uso")]
        [EnumDataType(typeof(TiposUso))]
        public TiposUso TipoUso { get; set; }

        [Display(Name = "Estado")]
        [EnumDataType(typeof(Estados))]
        public Estados Estado { get; set; }

        //[Timestamp]
        //public byte[] RowVersion { get; set; }

        [Display(Name = "Departamento")]
        public Departamento  Departamento { get; set; }
        public int DepartamentoId { get; set; }

        [Display(Name = "Ubicación")]
        public Ubicacion Ubicacion { get; set; }
        public int UbicacionId { get; set; }
    }
}

