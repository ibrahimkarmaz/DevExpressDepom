namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableCustomerMovementUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerMovements",
                c => new
                    {
                        CustomerMovementID = c.Int(nullable: false, identity: true),
                        CustomerMovementDate = c.DateTime(),
                        CustomerMovemenNote = c.String(),
                        CustomerMovemenArchive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerMovementID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerMovements");
        }
    }
}
