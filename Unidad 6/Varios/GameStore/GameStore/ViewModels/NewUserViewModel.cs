using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.ViewModels
{
    public class NewUserViewModel
    {
        [Required]
        [Display(Name = "Usuario")]
        public string User { get; set; }
        [Required]
        [StringLength(100,
        ErrorMessage = "La contraseña debe de tener 6 caracteres como mínimo.",
        MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password",
        ErrorMessage = "Las dos contraseñas introducidas no coinciden.")]
        public string ConfirmPassword { get; set; }
    }
}
