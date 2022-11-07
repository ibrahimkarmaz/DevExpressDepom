namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityExpenseHeaderUPDATE3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ExprenseHeaders");
            AddColumn("dbo.ExprenseHeaders", "ExprenseHeaderID2", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.ExprenseHeaders", "ExprenseHeaderID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ExprenseHeaders", "ExprenseHeaderID2");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ExprenseHeaders");
            AlterColumn("dbo.ExprenseHeaders", "ExprenseHeaderID", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.ExprenseHeaders", "ExprenseHeaderID2");
            AddPrimaryKey("dbo.ExprenseHeaders", "ExprenseHeaderID");
        }
    }
}
