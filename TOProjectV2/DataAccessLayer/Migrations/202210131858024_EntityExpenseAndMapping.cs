namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityExpenseAndMapping : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        ExpenseID = c.Int(nullable: false, identity: true),
                        ExpenseElectric = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpenseWater = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpenseNaturalGas = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpenseInternet = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpenseWage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpenseExtra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpenseNote = c.String(maxLength: 500),
                        ExpenseArchive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ExpenseID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Expenses");
        }
    }
}
