using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final_Multiplataforma.Models
{
    public class Productos
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Nombre de productos")]
        public string Nombre { get; set; }
        
        [Required]
        [Display(Name="Foto")]
        public string Foto { get; set; }
        
        [Required]        
        public Categorias Categoria { get; set; }

        [Required]
        public int CategoriaId { get; set; }
        [Required]
        public decimal PrecioUnit { get; set; }
        [Required]
        [Display(Name="Descripcion")]
        public string Descripcion { get; set; }
    }
}