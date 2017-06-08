namespace Agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracao3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoDeContato",
                c => new
                    {
                        IdTipoDeContato = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.IdTipoDeContato);
            
            AddColumn("dbo.Contato", "TipoDeContato_IdTipoDeContato", c => c.Int());
            CreateIndex("dbo.Contato", "TipoDeContato_IdTipoDeContato");
            AddForeignKey("dbo.Contato", "TipoDeContato_IdTipoDeContato", "dbo.TipoDeContato", "IdTipoDeContato");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contato", "TipoDeContato_IdTipoDeContato", "dbo.TipoDeContato");
            DropIndex("dbo.Contato", new[] { "TipoDeContato_IdTipoDeContato" });
            DropColumn("dbo.Contato", "TipoDeContato_IdTipoDeContato");
            DropTable("dbo.TipoDeContato");
        }
    }
}
