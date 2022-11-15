namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyMovementAndEmployeePKFKUPDATE : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CompanyMovements", "EmployeeID", c => c.Int(nullable: false));
            CreateIndex("dbo.CompanyMovements", "EmployeeID");
            AddForeignKey("dbo.CompanyMovements", "EmployeeID", "dbo.Employees", "EmployeeID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CompanyMovements", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.CompanyMovements", new[] { "EmployeeID" });
            DropColumn("dbo.CompanyMovements", "EmployeeID");
        }
    }
}
