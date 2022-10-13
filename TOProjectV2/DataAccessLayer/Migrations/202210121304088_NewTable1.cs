namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        CompanyOfficialNameSurName = c.String(),
                        CompanyOfficialStatus = c.String(),
                        CompanyPhone1 = c.String(),
                        CompanyPhone2 = c.String(),
                        CompanyPhone3 = c.String(),
                        CompanyMail = c.String(),
                        CompanyFax = c.String(),
                        CompanyTown = c.String(),
                        CompanyCounty = c.String(),
                        CompanyTaxOffice = c.String(),
                        CompanyAddress = c.String(),
                        CompanyArchive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CustomerTC = c.String(),
                        CustomerName = c.String(),
                        CustomerSurName = c.String(),
                        CustomerMobilePhone = c.String(),
                        CustomerOfficePhone = c.String(),
                        CustomerMail = c.String(),
                        CustomerTown = c.String(),
                        CustomerCounty = c.String(),
                        CustomerHomeAddress = c.String(),
                        CustomerTaxNumber = c.String(),
                        CustomerArchive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
            DropTable("dbo.Companies");
        }
    }
}
