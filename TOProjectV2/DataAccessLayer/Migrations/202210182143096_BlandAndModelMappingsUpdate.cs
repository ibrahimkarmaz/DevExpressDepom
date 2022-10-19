namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlandAndModelMappingsUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Blands", "Models_ModelID", "dbo.Models");
            DropIndex("dbo.Blands", new[] { "Models_ModelID" });
            RenameColumn(table: "dbo.Blands", name: "Models_ModelID", newName: "ModelID");
            AlterColumn("dbo.Blands", "ModelID", c => c.Int(nullable: false));
            CreateIndex("dbo.Blands", "ModelID");
            AddForeignKey("dbo.Blands", "ModelID", "dbo.Models", "ModelID", cascadeDelete: true);
            DropColumn("dbo.Models", "BlandID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Models", "BlandID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Blands", "ModelID", "dbo.Models");
            DropIndex("dbo.Blands", new[] { "ModelID" });
            AlterColumn("dbo.Blands", "ModelID", c => c.Int());
            RenameColumn(table: "dbo.Blands", name: "ModelID", newName: "Models_ModelID");
            CreateIndex("dbo.Blands", "Models_ModelID");
            AddForeignKey("dbo.Blands", "Models_ModelID", "dbo.Models", "ModelID");
        }
    }
}
