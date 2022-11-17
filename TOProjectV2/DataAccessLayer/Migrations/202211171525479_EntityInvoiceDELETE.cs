namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityInvoiceDELETE : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.InvoiceDetails");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                    {
                        InvoiceProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 20),
                        ProductPiece = c.Int(nullable: false),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InvoiceID = c.Decimal(nullable: false, precision: 18, scale: 2),
                        InvoiceArchive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceProductID);
            
        }
    }
}
