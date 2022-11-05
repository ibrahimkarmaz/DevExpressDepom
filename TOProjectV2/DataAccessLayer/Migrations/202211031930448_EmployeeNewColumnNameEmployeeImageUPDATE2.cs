namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeNewColumnNameEmployeeImageUPDATE2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "EmployeeImage", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "EmployeeImage", c => c.String());
        }
    }
}
