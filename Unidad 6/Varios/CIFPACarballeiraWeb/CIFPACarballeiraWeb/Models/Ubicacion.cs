using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIFPACarballeiraWeb.Models
{
    [Table("Ubicaciones")]
    public class Ubicacion
    {
        public int ID { get; set; }

        [Display(Name = "Ubicación")]
        [Required(ErrorMessage = "Debe introducir el nombre de la ubicación")]
        //[Remote("IsNameAvailable", "Ubicaciones", ErrorMessage = "O nome de ubicación xa existe.Non se admiten duplicados")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        public List<Material> Materiales { get; set; }
    }
}

/*   

       public JsonResult IsUbicacionExists(string UserName)
       {
           //check if any of the UserName matches the UserName specified in the Parameter using the ANY extension method.  
           return Json(!db.Users.Any(x => x.UserName == UserName), JsonRequestBehavior.AllowGet);
       }
       */
