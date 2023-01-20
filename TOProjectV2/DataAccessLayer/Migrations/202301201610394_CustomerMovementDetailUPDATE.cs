namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerMovementDetailUPDATE : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerMovementDetails", "CustomerMovementDetailPiece", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerMovementDetails", "CustomerMovementDetailPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.CustomerMovementDetails", "CustomerMovementDetailTotalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerMovementDetails", "CustomerMovementDetailTotalPrice", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.CustomerMovementDetails", "CustomerMovementDetailPrice", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.CustomerMovementDetails", "CustomerMovementDetailPiece", c => c.Int());
        }
    }
}
