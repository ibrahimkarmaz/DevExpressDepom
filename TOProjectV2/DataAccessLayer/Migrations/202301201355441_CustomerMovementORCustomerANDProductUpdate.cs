namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerMovementORCustomerANDProductUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerMovementDetails", "ProductID", c => c.Int());
            AddColumn("dbo.CustomerMovementDetails", "CustomerMovementID", c => c.Int());
            CreateIndex("dbo.CustomerMovementDetails", "ProductID");
            CreateIndex("dbo.CustomerMovementDetails", "CustomerMovementID");
            AddForeignKey("dbo.CustomerMovementDetails", "CustomerMovementID", "dbo.CustomerMovement", "CustomerMovementID");
            AddForeignKey("dbo.CustomerMovementDetails", "ProductID", "dbo.Products", "ProductID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerMovementDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.CustomerMovementDetails", "CustomerMovementID", "dbo.CustomerMovement");
            DropIndex("dbo.CustomerMovementDetails", new[] { "CustomerMovementID" });
            DropIndex("dbo.CustomerMovementDetails", new[] { "ProductID" });
            DropColumn("dbo.CustomerMovementDetails", "CustomerMovementID");
            DropColumn("dbo.CustomerMovementDetails", "ProductID");
        }
    }
}
