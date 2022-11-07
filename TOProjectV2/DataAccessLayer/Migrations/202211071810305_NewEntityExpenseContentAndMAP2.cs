namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewEntityExpenseContentAndMAP2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExpenseContents",
                c => new
                    {
                        ExpenseContentID = c.Int(nullable: false, identity: true),
                        ExpenseContentTitle = c.String(nullable: false, maxLength: 30),
                        ExpenseContentType = c.String(nullable: false, maxLength: 25),
                        ExpenseContentPeceiptNumber = c.String(nullable: false, maxLength: 20),
                        ExpenseContentPeceiptPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpenseContentPeceiptImage = c.String(maxLength: 250),
                        ExpenseContentNote = c.String(maxLength: 250),
                        ExpenseContentArchive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ExpenseContentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ExpenseContents");
        }
    }
}
