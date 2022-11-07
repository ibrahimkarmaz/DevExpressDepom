namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityExpenseHeaderUPDATE2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ExorenseHeaders", newName: "ExprenseHeaders");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ExprenseHeaders", newName: "ExorenseHeaders");
        }
    }
}
