namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEntityNameCompanyMovementDetailAndMAP : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompanyMovementDetails",
                c => new
                    {
                        CompanyMovementDetailID = c.Int(nullable: false, identity: true),
                        CompanyMovementDetailPiece = c.Int(nullable: false),
                        CompanyMovementDetailPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CompanyMovementDetailTotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CompanyMovementDetailID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CompanyMovementDetails");
        }
    }
}
