namespace WebApplicationMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplicationMVC.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplicationMVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplicationMVC.Models.ApplicationDbContext context)
        {
            context.Envasados.AddOrUpdate(
        e => e.Nombre,
        new Envasado { Nombre = "Plástico", Descripcion = "Envase plástico reciclable" },
        new Envasado { Nombre = "Vidrio", Descripcion = "Envase de vidrio retornable" },
        new Envasado { Nombre = "Lata", Descripcion = "Envase metálico" }
    );

            context.SaveChanges();
        }
    }
}
