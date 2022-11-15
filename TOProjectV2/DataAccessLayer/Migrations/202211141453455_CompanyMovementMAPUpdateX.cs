namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyMovementMAPUpdateX : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CompanyMovements", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.CompanyMovements", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.CompanyMovements", new[] { "EmployeeID" });
            DropIndex("dbo.CompanyMovements", new[] { "CompanyID" });
            AlterColumn("dbo.CompanyMovements", "EmployeeID", c => c.Int());
            AlterColumn("dbo.CompanyMovements", "CompanyID", c => c.Int());
            CreateIndex("dbo.CompanyMovements", "EmployeeID");
            CreateIndex("dbo.CompanyMovements", "CompanyID");
            AddForeignKey("dbo.CompanyMovements", "CompanyID", "dbo.Companies", "CompanyID");
            AddForeignKey("dbo.CompanyMovements", "EmployeeID", "dbo.Employees", "EmployeeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CompanyMovements", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.CompanyMovements", "CompanyID", "dbo.Companies");
            DropIndex("dbo.CompanyMovements", new[] { "CompanyID" });
            DropIndex("dbo.CompanyMovements", new[] { "EmployeeID" });
            AlterColumn("dbo.CompanyMovements", "CompanyID", c => c.Int(nullable: false));
            AlterColumn("dbo.CompanyMovements", "EmployeeID", c => c.Int(nullable: false));
            CreateIndex("dbo.CompanyMovements", "CompanyID");
            CreateIndex("dbo.CompanyMovements", "EmployeeID");
            AddForeignKey("dbo.CompanyMovements", "EmployeeID", "dbo.Employees", "EmployeeID", cascadeDelete: true);
            AddForeignKey("dbo.CompanyMovements", "CompanyID", "dbo.Companies", "CompanyID", cascadeDelete: true);
        }
    }
}
