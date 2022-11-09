namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpenseContentQueAddUPDATE : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ExpenseContents", "ExprenseHeaderID", "dbo.ExprenseHeaders");
            DropIndex("dbo.ExpenseContents", new[] { "ExprenseHeaderID" });
            AlterColumn("dbo.ExpenseContents", "ExprenseHeaderID", c => c.Int());
            CreateIndex("dbo.ExpenseContents", "ExprenseHeaderID");
            AddForeignKey("dbo.ExpenseContents", "ExprenseHeaderID", "dbo.ExprenseHeaders", "ExprenseHeaderID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExpenseContents", "ExprenseHeaderID", "dbo.ExprenseHeaders");
            DropIndex("dbo.ExpenseContents", new[] { "ExprenseHeaderID" });
            AlterColumn("dbo.ExpenseContents", "ExprenseHeaderID", c => c.Int(nullable: false));
            CreateIndex("dbo.ExpenseContents", "ExprenseHeaderID");
            AddForeignKey("dbo.ExpenseContents", "ExprenseHeaderID", "dbo.ExprenseHeaders", "ExprenseHeaderID", cascadeDelete: true);
        }
    }
}
