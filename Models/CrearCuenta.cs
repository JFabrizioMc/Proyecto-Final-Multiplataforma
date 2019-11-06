using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final_Multiplataforma.Models
{
    public class CrearCuenta 
    {
        //correo electronico
        [Required]
        [EmailAddress]
        [Display(Name="Correo electrónico")]
        public string Correo { get; set; }
        [Required]
        [Display(Name="Contraseña")]
        [DataType(DataType.Password)]
        //contraseña1
        public string Contraseña1 { get; set;}
        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Confirmar Contraseña")]
        [Compare("Contraseña1", ErrorMessage = "Las contraseñas no coinciden")]

        //contraseña2
        public string Contraseña2 { get; set; }



        
    }
}