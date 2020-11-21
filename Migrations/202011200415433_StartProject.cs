namespace Cine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartProject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Horarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Hora = c.String(),
                        Precio = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Horarios");
        }
    }
}
