using WebApplicationMVC.Models;

namespace WebApplicationMVC.Models
{
    public class ProductoNoPerecible : Producto
    {
        public int EnvasadoId { get; set; }
        public virtual Envasado Envasado { get; set; }
    }
}