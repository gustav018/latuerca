namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Proveedores : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Proveedores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RazonSocial = c.String(),
                        DocumentoNumero = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proveedores");
        }
    }
}
