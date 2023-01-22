namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableAndMAPCustomerMovementInvoice : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerMovementInvoices",
                c => new
                    {
                        CustomerMovementInvoiceID = c.Int(nullable: false, identity: true),
                        CustomerMovementID = c.Int(),
                        CustomerMovementInvoiceSeries = c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.CustomerMovementInvoiceID)
                .ForeignKey("dbo.CustomerMovement", t => t.CustomerMovementID)
                .Index(t => t.CustomerMovementID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerMovementInvoices", "CustomerMovementID", "dbo.CustomerMovement");
            DropIndex("dbo.CustomerMovementInvoices", new[] { "CustomerMovementID" });
            DropTable("dbo.CustomerMovementInvoices");
        }
    }
}
