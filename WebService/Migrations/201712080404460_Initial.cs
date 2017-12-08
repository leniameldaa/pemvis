namespace WebService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nama = c.String(),
                        idharga = c.Int(nullable: false),
                        deskripsi = c.String(),
                        rating = c.Single(nullable: false),
                        gambar = c.String(),
                        idToko = c.Int(nullable: false),
                        tglPost = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductModels");
        }
    }
}
