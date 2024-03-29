using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final_Multiplataforma.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name="Correo electrónico")]
        public string Correo { get; set; }

        [Required]
        [Display(Name="Contraseña")]
        [DataType(DataType.Password)]
        public string Password{ get; set; }
        
    }
}