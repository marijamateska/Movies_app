namespace Aud10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDbSets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Rating = c.Double(nullable: false),
                        ImgUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MovieClients",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false),
                        Client_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_Id, t.Client_Id })
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Client_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieClients", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.MovieClients", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.MovieClients", new[] { "Client_Id" });
            DropIndex("dbo.MovieClients", new[] { "Movie_Id" });
            DropTable("dbo.MovieClients");
            DropTable("dbo.Movies");
            DropTable("dbo.Clients");
        }
    }
}
