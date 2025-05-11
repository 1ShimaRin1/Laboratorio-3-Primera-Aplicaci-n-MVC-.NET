using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models
{
    public class Envasado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }
    }
}