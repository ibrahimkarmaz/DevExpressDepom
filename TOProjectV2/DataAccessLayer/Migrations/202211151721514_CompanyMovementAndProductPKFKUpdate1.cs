namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyMovementAndProductPKFKUpdate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CompanyMovementDetails", "ProductID", c => c.Int());
            CreateIndex("dbo.CompanyMovementDetails", "ProductID");
            AddForeignKey("dbo.CompanyMovementDetails", "ProductID", "dbo.Products", "ProductID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CompanyMovementDetails", "ProductID", "dbo.Products");
            DropIndex("dbo.CompanyMovementDetails", new[] { "ProductID" });
            DropColumn("dbo.CompanyMovementDetails", "ProductID");
        }
    }
}
