namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityExpenseHeaderUPDATE4 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ExprenseHeaders");
            AlterColumn("dbo.ExprenseHeaders", "ExprenseHeaderID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ExprenseHeaders", "ExprenseHeaderID");
            DropColumn("dbo.ExprenseHeaders", "ExprenseHeaderID2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ExprenseHeaders", "ExprenseHeaderID2", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.ExprenseHeaders");
            AlterColumn("dbo.ExprenseHeaders", "ExprenseHeaderID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ExprenseHeaders", "ExprenseHeaderID2");
        }
    }
}
