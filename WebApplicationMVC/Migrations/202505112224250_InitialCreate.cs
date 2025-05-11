namespace WebApplicationMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Envasadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        CodigoDeBarra = c.String(nullable: false),
                        Precio = c.Int(nullable: false),
                        CantidadDisponible = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        EnvasadoId = c.Int(),
                        FechaDeVencimiento = c.DateTime(),
                        Tipo = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Envasadoes", t => t.EnvasadoId, cascadeDelete: true)
                .Index(t => t.EnvasadoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productoes", "EnvasadoId", "dbo.Envasadoes");
            DropIndex("dbo.Productoes", new[] { "EnvasadoId" });
            DropTable("dbo.Productoes");
            DropTable("dbo.Envasadoes");
        }
    }
}
