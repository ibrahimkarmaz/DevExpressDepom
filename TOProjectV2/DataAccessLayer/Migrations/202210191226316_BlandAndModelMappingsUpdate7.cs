namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlandAndModelMappingsUpdate7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Models", "BlandID", c => c.Int(nullable: false));
            CreateIndex("dbo.Models", "BlandID");
            AddForeignKey("dbo.Models", "BlandID", "dbo.Blands", "BlandID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Models", "BlandID", "dbo.Blands");
            DropIndex("dbo.Models", new[] { "BlandID" });
            DropColumn("dbo.Models", "BlandID");
        }
    }
}
