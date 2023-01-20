namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableCustomerMovementDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerMovementDetails",
                c => new
                    {
                        CustomerMovementDetailID = c.Int(nullable: false, identity: true),
                        CustomerMovementDetailPiece = c.Int(),
                        CustomerMovementDetailPrice = c.Decimal(precision: 18, scale: 2),
                        CustomerMovementDetailTotalPrice = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CustomerMovementDetailID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerMovementDetails");
        }
    }
}
