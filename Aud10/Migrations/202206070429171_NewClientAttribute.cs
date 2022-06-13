namespace Aud10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewClientAttribute : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "Email");
        }
    }
}
