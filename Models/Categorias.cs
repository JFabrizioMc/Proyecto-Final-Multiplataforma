using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final_Multiplataforma.Models
{
    public class Categorias
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Nombre de categoría")]
        public string Nombre { get; set; }
        public List<Productos> Productos { get; set; }
    }
}