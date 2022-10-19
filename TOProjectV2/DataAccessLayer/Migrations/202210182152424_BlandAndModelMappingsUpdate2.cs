namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlandAndModelMappingsUpdate2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Blands", "ModelID", "dbo.Models");
            DropIndex("dbo.Blands", new[] { "ModelID" });
            RenameColumn(table: "dbo.Blands", name: "ModelID", newName: "Model_ModelID");
            AlterColumn("dbo.Blands", "Model_ModelID", c => c.Int());
            CreateIndex("dbo.Blands", "Model_ModelID");
            AddForeignKey("dbo.Blands", "Model_ModelID", "dbo.Models", "ModelID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blands", "Model_ModelID", "dbo.Models");
            DropIndex("dbo.Blands", new[] { "Model_ModelID" });
            AlterColumn("dbo.Blands", "Model_ModelID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Blands", name: "Model_ModelID", newName: "ModelID");
            CreateIndex("dbo.Blands", "ModelID");
            AddForeignKey("dbo.Blands", "ModelID", "dbo.Models", "ModelID", cascadeDelete: true);
        }
    }
}
