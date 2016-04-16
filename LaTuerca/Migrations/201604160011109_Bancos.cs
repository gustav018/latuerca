namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bancos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bancos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreBancos = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bancos");
        }
    }
}
