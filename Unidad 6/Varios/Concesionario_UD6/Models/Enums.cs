using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Concesionario_UD6.Models
{
    public enum TiposVehiculo
    {
        [Display(Name = "Coche")]
        Coche,
        [Display(Name = "Monovolumen")]
        Monovolumen,
        [Display(Name = "SUV")]
        SUV,
        [Display(Name = "Todoterreno")]
        Todoterreno,
        [Display(Name = "Furgoneta")]
        Furgoneta,
        [Display(Name = "Furgón")]
        Furgon,
        [Display(Name = "Camión lixeiro")]
        Equipamento,
        [Display(Name = "Outros")]
        Outros
    }

    public enum Combustibles
    {
        [Display(Name = "Gasolina")]
        Gasolina,
        [Display(Name = "Diésel")]
        Diesel,
        [Display(Name = "Híbrido")]
        Hibrido,
        [Display(Name = "Eléctrico")]
        Electrico
    }

    public enum Estados
    {
        [Display(Name = "Novo")]
        Novo,
        [Display(Name = "Semi-novo")]
        Seminovo,
        [Display(Name = "Kilómetro 0")]
        KM0,
        [Display(Name = "Renting")]
        Renting
    }


}
