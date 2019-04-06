using System.ComponentModel.DataAnnotations;
namespace GameStore.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña antigua")]
        public string OldPassword { get; set; }
        [Required]
        [StringLength(100,
        ErrorMessage = "La contraseña debe de tener 6 caracteres como mínimo.",
        MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nueva contraseña")]
        public string NewPassword { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("NewPassword",
        ErrorMessage = "Las dos contraseñas introducidas no coinciden.")]
        public string ConfirmPassword { get; set; }
    }
}
