namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlandAndModelMappings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blands",
                c => new
                    {
                        BlandID = c.Int(nullable: false, identity: true),
                        BlandName = c.String(nullable: false, maxLength: 20),
                        Models_ModelID = c.Int(),
                    })
                .PrimaryKey(t => t.BlandID)
                .ForeignKey("dbo.Models", t => t.Models_ModelID)
                .Index(t => t.BlandName, unique: true)
                .Index(t => t.Models_ModelID);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ModelID = c.Int(nullable: false, identity: true),
                        ModelName = c.String(nullable: false, maxLength: 20),
                        ModelYear = c.String(nullable: false, maxLength: 4),
                        BlandID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModelID)
                .Index(t => t.ModelName, unique: true)
                .Index(t => t.ModelYear, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blands", "Models_ModelID", "dbo.Models");
            DropIndex("dbo.Models", new[] { "ModelYear" });
            DropIndex("dbo.Models", new[] { "ModelName" });
            DropIndex("dbo.Blands", new[] { "Models_ModelID" });
            DropIndex("dbo.Blands", new[] { "BlandName" });
            DropTable("dbo.Models");
            DropTable("dbo.Blands");
        }
    }
}
