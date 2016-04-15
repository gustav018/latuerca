namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Repuesto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Repuestos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreRepuesto = c.String(),
                        UnidadDeMedida = c.String(),
                        Proveedor = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Categoria = c.String(),
                        PrecioCosto = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Repuestos");
        }
    }
}
