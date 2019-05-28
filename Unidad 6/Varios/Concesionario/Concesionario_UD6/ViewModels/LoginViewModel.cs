using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Concesionario_UD6.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Usuario")]
        public string User { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contrasinal")]
        public string Password { get; set; }
        [Display(Name = "Recordar a conta?")]
        public bool RememberMe { get; set; }
    }
}
