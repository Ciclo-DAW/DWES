using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIFPACarballeiraWeb.Models
{
    [Table("Departamentos")]
    public class Departamento
    {
        public int ID { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Se debe introducir el nombre del departamento")]
        //[Remote("IsDepartmentAvailable", "Departamentos", ErrorMessage = "O departamento xa existe. Non se admiten nomes duplicados")]
        public string Nombre { get; set; }

        public List<Material> Materiales { get; set; }


        /*   

           public JsonResult IsDepartmentExists(string UserName)
           {
               //check if any of the UserName matches the UserName specified in the Parameter using the ANY extension method.  
               return Json(!db.Users.Any(x => x.UserName == UserName), JsonRequestBehavior.AllowGet);
           }
           */
    }
}
