namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductPriceDoubleTypeSetDecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProductPurchasePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Products", "ProductSalePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ProductSalePrice", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "ProductPurchasePrice", c => c.Double(nullable: false));
        }
    }
}
