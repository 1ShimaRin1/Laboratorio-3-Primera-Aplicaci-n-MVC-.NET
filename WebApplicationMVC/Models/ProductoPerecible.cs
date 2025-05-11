using System;
using System.ComponentModel.DataAnnotations;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Models
{
    public class ProductoPerecible : Producto
    {
        [Required]
        [Display(Name = "Fecha de Vencimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaDeVencimiento { get; set; }

        [Display(Name = "Días para Vencer")]
        public int DiasParaVencer => (FechaDeVencimiento - DateTime.Today).Days;
    }
}