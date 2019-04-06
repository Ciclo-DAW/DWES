using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Concesionario_UD6.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contrasinal antigo")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100,
            ErrorMessage = "O contrasinal ten que ter un mínimo de 6 caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Novo contrasinal")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contrasinal")]
        [Compare("NewPassword", ErrorMessage = "Os dous contrasinais introducidos non coinciden.")]
        public string ConfirmPassword { get; set; }
    }
}
