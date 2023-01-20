namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnEditCustomerMovementMAP1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CustomerMovements", newName: "CustomerMovement");
            AlterColumn("dbo.CustomerMovement", "CustomerMovementDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CustomerMovement", "CustomerMovemenNote", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerMovement", "CustomerMovemenNote", c => c.String());
            AlterColumn("dbo.CustomerMovement", "CustomerMovementDate", c => c.DateTime());
            RenameTable(name: "dbo.CustomerMovement", newName: "CustomerMovements");
        }
    }
}
