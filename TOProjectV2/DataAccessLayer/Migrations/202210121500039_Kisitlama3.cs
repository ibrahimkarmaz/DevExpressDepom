namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Kisitlama3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CustomerTC", c => c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false));
            AlterColumn("dbo.Customers", "CustomerName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "CustomerSurName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "CustomerMobilePhone", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Customers", "CustomerOfficePhone", c => c.String(maxLength: 15));
            AlterColumn("dbo.Customers", "CustomerMail", c => c.String(maxLength: 40));
            AlterColumn("dbo.Customers", "CustomerTown", c => c.String(nullable: false, maxLength: 13));
            AlterColumn("dbo.Customers", "CustomerCounty", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "CustomerHomeAddress", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Customers", "CustomerTaxNumber", c => c.String(nullable: false, maxLength: 30));
            CreateIndex("dbo.Customers", "CustomerTC", unique: true);
            CreateIndex("dbo.Customers", "CustomerMobilePhone", unique: true);
            CreateIndex("dbo.Customers", "CustomerOfficePhone", unique: true);
            CreateIndex("dbo.Customers", "CustomerMail", unique: true);
            CreateIndex("dbo.Customers", "CustomerTaxNumber", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "CustomerTaxNumber" });
            DropIndex("dbo.Customers", new[] { "CustomerMail" });
            DropIndex("dbo.Customers", new[] { "CustomerOfficePhone" });
            DropIndex("dbo.Customers", new[] { "CustomerMobilePhone" });
            DropIndex("dbo.Customers", new[] { "CustomerTC" });
            AlterColumn("dbo.Customers", "CustomerTaxNumber", c => c.String());
            AlterColumn("dbo.Customers", "CustomerHomeAddress", c => c.String());
            AlterColumn("dbo.Customers", "CustomerCounty", c => c.String());
            AlterColumn("dbo.Customers", "CustomerTown", c => c.String());
            AlterColumn("dbo.Customers", "CustomerMail", c => c.String());
            AlterColumn("dbo.Customers", "CustomerOfficePhone", c => c.String());
            AlterColumn("dbo.Customers", "CustomerMobilePhone", c => c.String());
            AlterColumn("dbo.Customers", "CustomerSurName", c => c.String());
            AlterColumn("dbo.Customers", "CustomerName", c => c.String());
            AlterColumn("dbo.Customers", "CustomerTC", c => c.String());
        }
    }
}
