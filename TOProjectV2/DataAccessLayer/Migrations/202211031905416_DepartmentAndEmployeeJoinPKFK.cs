namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepartmentAndEmployeeJoinPKFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "DepartmentID", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "DepartmentID");
            AddForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments", "DepartmentID", cascadeDelete: true);
            DropColumn("dbo.Employees", "EmployeeTask");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "EmployeeTask", c => c.String(nullable: false, maxLength: 20));
            DropForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartmentID" });
            DropColumn("dbo.Employees", "DepartmentID");
        }
    }
}
