namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductBlandPKUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "BlandID", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "BlandID");
            AddForeignKey("dbo.Products", "BlandID", "dbo.Blands", "BlandID", cascadeDelete: true);
            DropColumn("dbo.Products", "ProductBland");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProductBland", c => c.String(nullable: false, maxLength: 20));
            DropForeignKey("dbo.Products", "BlandID", "dbo.Blands");
            DropIndex("dbo.Products", new[] { "BlandID" });
            DropColumn("dbo.Products", "BlandID");
        }
    }
}
