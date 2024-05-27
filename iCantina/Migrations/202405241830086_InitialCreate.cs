namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilizadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeUtilizador = c.String(),
                        NIFUtilizador = c.Int(),
                        UsernameFuncionario = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Utilizadors");
        }
    }
}
