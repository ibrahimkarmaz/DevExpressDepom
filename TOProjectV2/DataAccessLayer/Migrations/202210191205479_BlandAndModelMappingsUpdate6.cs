namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlandAndModelMappingsUpdate6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Blands", "Model_ModelID", "dbo.Models");
            DropIndex("dbo.Blands", new[] { "Model_ModelID" });
            DropColumn("dbo.Blands", "Model_ModelID");
            DropColumn("dbo.Models", "BlandID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Models", "BlandID", c => c.Int(nullable: false));
            AddColumn("dbo.Blands", "Model_ModelID", c => c.Int());
            CreateIndex("dbo.Blands", "Model_ModelID");
            AddForeignKey("dbo.Blands", "Model_ModelID", "dbo.Models", "ModelID");
        }
    }
}
