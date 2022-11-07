namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityExpenseHeaderUPDATE : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ExorenseHeaders", new[] { "ExorenseHeaderName" });
            DropPrimaryKey("dbo.ExorenseHeaders");
            AddColumn("dbo.ExorenseHeaders", "ExprenseHeaderID", c => c.Int(nullable: false, identity: false));
            AddColumn("dbo.ExorenseHeaders", "ExprenseHeaderName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.ExorenseHeaders", "ExprenseHeaderStartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ExorenseHeaders", "ExprenseHeaderStopDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ExorenseHeaders", "ExprenseHeaderDetail", c => c.String(maxLength: 250));
            AddPrimaryKey("dbo.ExorenseHeaders", "ExprenseHeaderID");
            CreateIndex("dbo.ExorenseHeaders", "ExprenseHeaderName", unique: true);
            DropColumn("dbo.ExorenseHeaders", "ExorenseHeaderID");
            DropColumn("dbo.ExorenseHeaders", "ExorenseHeaderName");
            DropColumn("dbo.ExorenseHeaders", "ExorenseHeaderStartDate");
            DropColumn("dbo.ExorenseHeaders", "ExorenseHeaderStopDate");
            DropColumn("dbo.ExorenseHeaders", "ExorenseHeaderDetail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ExorenseHeaders", "ExorenseHeaderDetail", c => c.String(maxLength: 250));
            AddColumn("dbo.ExorenseHeaders", "ExorenseHeaderStopDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ExorenseHeaders", "ExorenseHeaderStartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ExorenseHeaders", "ExorenseHeaderName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.ExorenseHeaders", "ExorenseHeaderID", c => c.Int(nullable: false, identity: true));
            DropIndex("dbo.ExorenseHeaders", new[] { "ExprenseHeaderName" });
            DropPrimaryKey("dbo.ExorenseHeaders");
            DropColumn("dbo.ExorenseHeaders", "ExprenseHeaderDetail");
            DropColumn("dbo.ExorenseHeaders", "ExprenseHeaderStopDate");
            DropColumn("dbo.ExorenseHeaders", "ExprenseHeaderStartDate");
            DropColumn("dbo.ExorenseHeaders", "ExprenseHeaderName");
            DropColumn("dbo.ExorenseHeaders", "ExprenseHeaderID");
            AddPrimaryKey("dbo.ExorenseHeaders", "ExorenseHeaderID");
            CreateIndex("dbo.ExorenseHeaders", "ExorenseHeaderName", unique: true);
        }
    }
}
