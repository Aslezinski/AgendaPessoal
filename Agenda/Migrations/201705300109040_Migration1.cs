namespace Agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contato",
                c => new
                    {
                        IdContato = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        Apelido = c.String(),
                        Telefone = c.String(),
                        Celular = c.String(),
                    })
                .PrimaryKey(t => t.IdContato);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contato");
        }
    }
}
