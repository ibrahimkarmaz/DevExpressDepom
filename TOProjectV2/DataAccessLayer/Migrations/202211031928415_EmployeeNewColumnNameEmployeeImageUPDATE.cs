namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeNewColumnNameEmployeeImageUPDATE : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmployeeImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "EmployeeImage");
        }
    }
}
