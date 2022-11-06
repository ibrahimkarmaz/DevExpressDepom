namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpenseHeaderNewColumnAndMap : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExorenseHeaders", "ExorenseHeaderDetail", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExorenseHeaders", "ExorenseHeaderDetail");
        }
    }
}
