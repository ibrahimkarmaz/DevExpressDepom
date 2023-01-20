namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewPKFKCustomerMovement : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerMovement", "EmployeeID", c => c.Int());
            AddColumn("dbo.CustomerMovement", "CustomerID", c => c.Int());
            CreateIndex("dbo.CustomerMovement", "EmployeeID");
            CreateIndex("dbo.CustomerMovement", "CustomerID");
            AddForeignKey("dbo.CustomerMovement", "EmployeeID", "dbo.Employees", "EmployeeID");
            AddForeignKey("dbo.CustomerMovement", "CustomerID", "dbo.Customers", "CustomerID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerMovement", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.CustomerMovement", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.CustomerMovement", new[] { "CustomerID" });
            DropIndex("dbo.CustomerMovement", new[] { "EmployeeID" });
            DropColumn("dbo.CustomerMovement", "CustomerID");
            DropColumn("dbo.CustomerMovement", "EmployeeID");
        }
    }
}
