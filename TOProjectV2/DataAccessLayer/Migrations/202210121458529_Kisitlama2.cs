namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Kisitlama2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "CompanyOfficialNameSurName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Companies", "CompanyOfficialStatus", c => c.String(maxLength: 30));
            AlterColumn("dbo.Companies", "CompanyPhone1", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Companies", "CompanyPhone2", c => c.String(maxLength: 15));
            AlterColumn("dbo.Companies", "CompanyPhone3", c => c.String(maxLength: 15));
            AlterColumn("dbo.Companies", "CompanyMail", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Companies", "CompanyFax", c => c.String(maxLength: 15));
            AlterColumn("dbo.Companies", "CompanyTown", c => c.String(nullable: false, maxLength: 13));
            AlterColumn("dbo.Companies", "CompanyCounty", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Companies", "CompanyTaxOffice", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Companies", "CompanyAddress", c => c.String(nullable: false, maxLength: 250));
            CreateIndex("dbo.Companies", "CompanyPhone1", unique: true);
            CreateIndex("dbo.Companies", "CompanyMail", unique: true);
            CreateIndex("dbo.Companies", "CompanyFax", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Companies", new[] { "CompanyFax" });
            DropIndex("dbo.Companies", new[] { "CompanyMail" });
            DropIndex("dbo.Companies", new[] { "CompanyPhone1" });
            AlterColumn("dbo.Companies", "CompanyAddress", c => c.String());
            AlterColumn("dbo.Companies", "CompanyTaxOffice", c => c.String());
            AlterColumn("dbo.Companies", "CompanyCounty", c => c.String());
            AlterColumn("dbo.Companies", "CompanyTown", c => c.String());
            AlterColumn("dbo.Companies", "CompanyFax", c => c.String());
            AlterColumn("dbo.Companies", "CompanyMail", c => c.String());
            AlterColumn("dbo.Companies", "CompanyPhone3", c => c.String());
            AlterColumn("dbo.Companies", "CompanyPhone2", c => c.String());
            AlterColumn("dbo.Companies", "CompanyPhone1", c => c.String());
            AlterColumn("dbo.Companies", "CompanyOfficialStatus", c => c.String());
            AlterColumn("dbo.Companies", "CompanyOfficialNameSurName", c => c.String());
        }
    }
}
