namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityInvoiceAndMapping : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false, identity: true),
                        InvoiceSeries = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                        InvoiceDesk = c.String(nullable: false, maxLength: 10),
                        InvoiceDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        InvoiceTime = c.DateTime(nullable: false),
                        InvoiceTaxOffice = c.String(nullable: false, maxLength: 40),
                        InvoiceBuyer = c.String(nullable: false, maxLength: 40),
                        InvoiceSubmitter = c.String(nullable: false, maxLength: 40),
                        InvoiceDeliveryArea = c.String(nullable: false, maxLength: 40),
                        InvoiceArchive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Invoices");
        }
    }
}
