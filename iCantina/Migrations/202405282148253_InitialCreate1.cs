namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pratoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        descricaoPrato = c.String(),
                        tipoPrato = c.String(),
                        estadoPrato = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pratoes");
        }
    }
}
