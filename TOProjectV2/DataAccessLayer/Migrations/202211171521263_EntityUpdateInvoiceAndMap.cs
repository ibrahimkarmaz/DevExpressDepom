namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityUpdateInvoiceAndMap : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "CompanyMovementID", c => c.Int());
            AlterColumn("dbo.Invoices", "InvoiceSeries", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
            CreateIndex("dbo.Invoices", "CompanyMovementID");
            AddForeignKey("dbo.Invoices", "CompanyMovementID", "dbo.CompanyMovements", "CompanyMovementID");
            DropColumn("dbo.Invoices", "InvoiceDesk");
            DropColumn("dbo.Invoices", "InvoiceDate");
            DropColumn("dbo.Invoices", "InvoiceTime");
            DropColumn("dbo.Invoices", "InvoiceTaxOffice");
            DropColumn("dbo.Invoices", "InvoiceBuyer");
            DropColumn("dbo.Invoices", "InvoiceSubmitter");
            DropColumn("dbo.Invoices", "InvoiceDeliveryArea");
            DropColumn("dbo.Invoices", "InvoiceArchive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Invoices", "InvoiceArchive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Invoices", "InvoiceDeliveryArea", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Invoices", "InvoiceSubmitter", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Invoices", "InvoiceBuyer", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Invoices", "InvoiceTaxOffice", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Invoices", "InvoiceTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Invoices", "InvoiceDate", c => c.DateTime(nullable: false, storeType: "smalldatetime"));
            AddColumn("dbo.Invoices", "InvoiceDesk", c => c.String(nullable: false, maxLength: 10));
            DropForeignKey("dbo.Invoices", "CompanyMovementID", "dbo.CompanyMovements");
            DropIndex("dbo.Invoices", new[] { "CompanyMovementID" });
            AlterColumn("dbo.Invoices", "InvoiceSeries", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
            DropColumn("dbo.Invoices", "CompanyMovementID");
        }
    }
}
