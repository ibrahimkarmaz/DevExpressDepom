namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductDecimalUpdateTypeDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProductPurchasePrice", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "ProductSalePrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ProductSalePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Products", "ProductPurchasePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
