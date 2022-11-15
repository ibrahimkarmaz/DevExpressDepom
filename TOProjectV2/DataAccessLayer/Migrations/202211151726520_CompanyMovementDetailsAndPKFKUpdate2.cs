namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyMovementDetailsAndPKFKUpdate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CompanyMovementDetails", "CompanyMovementID", c => c.Int());
            CreateIndex("dbo.CompanyMovementDetails", "CompanyMovementID");
            AddForeignKey("dbo.CompanyMovementDetails", "CompanyMovementID", "dbo.CompanyMovements", "CompanyMovementID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CompanyMovementDetails", "CompanyMovementID", "dbo.CompanyMovements");
            DropIndex("dbo.CompanyMovementDetails", new[] { "CompanyMovementID" });
            DropColumn("dbo.CompanyMovementDetails", "CompanyMovementID");
        }
    }
}
