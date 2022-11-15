namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyMovementAndCompanyPKFKUPDATE : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CompanyMovements", "CompanyID", c => c.Int(nullable: false));
            CreateIndex("dbo.CompanyMovements", "CompanyID");
            AddForeignKey("dbo.CompanyMovements", "CompanyID", "dbo.Companies", "CompanyID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CompanyMovements", "CompanyID", "dbo.Companies");
            DropIndex("dbo.CompanyMovements", new[] { "CompanyID" });
            DropColumn("dbo.CompanyMovements", "CompanyID");
        }
    }
}
