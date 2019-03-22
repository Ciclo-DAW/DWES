using System.ComponentModel.DataAnnotations;

namespace CIFPACarballeiraWeb.Models
{
    public enum TiposMaterial
    {
        [Display(Name = "Informático")]
        Informatico,
        [Display(Name = "Audiovisual")]
        AudioVisual,
        [Display(Name = "Bibliografía")]
        Bibliografia,
        [Display(Name = "Equipamiento")]
        Equipamento,
        [Display(Name = "Otros")]
        Otros,
        [Display(Name = "Mobiliario")]
        Mobiliario,
        [Display(Name = "Recursos didácticos")]
        RecursosDidacticos
    }

    public enum TiposUso
    {
        [Display(Name = "En uso")]
        EnUso,
        [Display(Name = "Almacén")]
        Almacen,
        [Display(Name ="Retirado")]
        Retirado

    }
    public enum Estados
    {
        [Display(Name = "Bueno")]
        Bueno,
        [Display(Name = "Regular")]
        Regular,
        [Display(Name = "Malo")]
        Malo
    }
}
