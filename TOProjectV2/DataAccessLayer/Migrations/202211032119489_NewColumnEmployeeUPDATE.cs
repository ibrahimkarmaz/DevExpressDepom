namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColumnEmployeeUPDATE : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmployeeGender", c => c.Boolean(nullable: false));
            AddColumn("dbo.Employees", "EmployeeDateOfBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "EmployeeDateOfBirth");
            DropColumn("dbo.Employees", "EmployeeGender");
        }
    }
}
