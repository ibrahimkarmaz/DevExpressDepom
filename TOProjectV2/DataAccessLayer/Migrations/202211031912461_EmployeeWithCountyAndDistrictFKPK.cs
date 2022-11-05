namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeWithCountyAndDistrictFKPK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartmentID" });
            AddColumn("dbo.Employees", "CountyID", c => c.Int());
            AddColumn("dbo.Employees", "DistrictID", c => c.Int());
            AlterColumn("dbo.Employees", "DepartmentID", c => c.Int());
            CreateIndex("dbo.Employees", "CountyID");
            CreateIndex("dbo.Employees", "DistrictID");
            CreateIndex("dbo.Employees", "DepartmentID");
            AddForeignKey("dbo.Employees", "CountyID", "dbo.Countys", "CountyID");
            AddForeignKey("dbo.Employees", "DistrictID", "dbo.Districts", "DistrictID");
            AddForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments", "DepartmentID");
            DropColumn("dbo.Employees", "EmployeeTown");
            DropColumn("dbo.Employees", "EmployeeCounty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "EmployeeCounty", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Employees", "EmployeeTown", c => c.String(nullable: false, maxLength: 13));
            DropForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Employees", "DistrictID", "dbo.Districts");
            DropForeignKey("dbo.Employees", "CountyID", "dbo.Countys");
            DropIndex("dbo.Employees", new[] { "DepartmentID" });
            DropIndex("dbo.Employees", new[] { "DistrictID" });
            DropIndex("dbo.Employees", new[] { "CountyID" });
            AlterColumn("dbo.Employees", "DepartmentID", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "DistrictID");
            DropColumn("dbo.Employees", "CountyID");
            CreateIndex("dbo.Employees", "DepartmentID");
            AddForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments", "DepartmentID", cascadeDelete: true);
        }
    }
}
