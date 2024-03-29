using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Final_Multiplataforma.Models
{
    public class CrearCuentaViewModel 
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
        public string Password1 { get; set;}
        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Confirmar Contraseña")]
        [Compare("Password1", ErrorMessage = "Las contraseñas no coinciden")]
      

        //contraseña2
        public string Password2 { get; set; }



        
    }
}