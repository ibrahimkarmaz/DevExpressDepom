namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityProductAndMapping : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 20),
                        ProductBland = c.String(nullable: false, maxLength: 20),
                        ProductModel = c.String(nullable: false, maxLength: 20),
                        ProductYear = c.String(nullable: false, maxLength: 4, fixedLength: true, unicode: false),
                        ProductPiece = c.Int(nullable: false),
                        ProductPurchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductSalePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductArchive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
