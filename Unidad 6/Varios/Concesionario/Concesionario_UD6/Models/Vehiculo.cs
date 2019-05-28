using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Concesionario_UD6.Models
{
    public class Vehiculo
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 1, ErrorMessage = "Débese engadir a marca do vehículo")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [StringLength(60, MinimumLength = 1, ErrorMessage = "Débese engadir o modelo do vehículo")]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Display(Name = "Tipo de vehículo")]
        [EnumDataType(typeof(TiposVehiculo))]
        public TiposVehiculo TipoVehiculo { get; set; }

        [Display(Name = "Combustible")]
        [EnumDataType(typeof(Combustibles))]
        public Combustibles Combustible { get; set; }

        [Display(Name = "Estado")]
        [EnumDataType(typeof(Estados))]
        public Estados Estado { get; set; }

        [Display(Name = "Descripción")]
        public String Descripcion { get; set; }

        [Display(Name = "Número de Bastidor")]
        public string NumBastidor { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",
        ApplyFormatInEditMode = true)]
        [Display(Name = "Data de chegada")]
        public DateTime? DataRecepcion { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",
        ApplyFormatInEditMode = true)]
        [Display(Name = "Vendido na data")]
        public DateTime? DataVenta { get; set; }  

        [Display(Name = "Concesionario")]
        public Concesionario Concesionario { get; set; }
        public int ConcesionarioId { get; set; }
        
        [Display(Name = "Ubicacion")]
        public Ubicacion Ubicacion { get; set; }
        public int UbicacionId { get; set; }
    }
}
