namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlandAndModelMappingsUpdate3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Models", "BlandID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Models", "BlandID");
        }
    }
}
