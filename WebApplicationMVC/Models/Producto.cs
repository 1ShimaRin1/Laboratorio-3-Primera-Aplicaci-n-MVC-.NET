using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [Display(Name = "Nombre del Producto")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Código de Barras")]
        public string CodigoDeBarra { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Precio inválido")]
        public int Precio { get; set; }

        [Required]
        [Display(Name = "Cantidad Disponible")]
        public int CantidadDisponible { get; set; }

        [Display(Name = "Disponible")]
        public bool Estado { get; set; } = true;
    }
}