namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityBankAndCompanyFKPKAndMAPUPDATE : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Banks", new[] { "BankAccountName" });
            AddColumn("dbo.Banks", "CompanyID", c => c.Int(nullable: false));
            CreateIndex("dbo.Banks", "CompanyID");
            AddForeignKey("dbo.Banks", "CompanyID", "dbo.Companies", "CompanyID", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Banks", "CompanyID", "dbo.Companies");
            DropIndex("dbo.Banks", new[] { "CompanyID" });
            DropColumn("dbo.Banks", "CompanyID");
            CreateIndex("dbo.Banks", "BankAccountName", unique: true);
        }
    }
}
