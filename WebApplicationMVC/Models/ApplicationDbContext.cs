using System.Collections.Generic;
using System.Data.Entity;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=DefaultConnection") { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Envasado> Envasados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .Map<ProductoPerecible>(m => m.Requires("Tipo").HasValue("Perecible"))
                .Map<ProductoNoPerecible>(m => m.Requires("Tipo").HasValue("NoPerecible"));
        }

        public System.Data.Entity.DbSet<WebApplicationMVC.Models.ProductoPerecible> Productoes { get; set; }
    }
}