namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewExpenseHeaderAndContextPKFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExpenseContents", "ExprenseHeaderID", c => c.Int(nullable: false));
            CreateIndex("dbo.ExpenseContents", "ExprenseHeaderID");
            AddForeignKey("dbo.ExpenseContents", "ExprenseHeaderID", "dbo.ExprenseHeaders", "ExprenseHeaderID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExpenseContents", "ExprenseHeaderID", "dbo.ExprenseHeaders");
            DropIndex("dbo.ExpenseContents", new[] { "ExprenseHeaderID" });
            DropColumn("dbo.ExpenseContents", "ExprenseHeaderID");
        }
    }
}
