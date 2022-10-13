namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KisitlamaEkleme1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "EmployeeTC", c => c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false));
            AlterColumn("dbo.Employees", "EmployeeName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Employees", "EmployeeSurName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Employees", "EmployeePhone", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Employees", "EmployeeMail", c => c.String(maxLength: 40));
            AlterColumn("dbo.Employees", "EmployeeTown", c => c.String(nullable: false, maxLength: 13));
            AlterColumn("dbo.Employees", "EmployeeCounty", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Employees", "EmployeeHomeAddress", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Employees", "EmployeeTask", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.Employees", "EmployeeTC", unique: true);
            CreateIndex("dbo.Employees", "EmployeePhone", unique: true);
            CreateIndex("dbo.Employees", "EmployeeMail", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Employees", new[] { "EmployeeMail" });
            DropIndex("dbo.Employees", new[] { "EmployeePhone" });
            DropIndex("dbo.Employees", new[] { "EmployeeTC" });
            AlterColumn("dbo.Employees", "EmployeeTask", c => c.String());
            AlterColumn("dbo.Employees", "EmployeeHomeAddress", c => c.String());
            AlterColumn("dbo.Employees", "EmployeeCounty", c => c.String());
            AlterColumn("dbo.Employees", "EmployeeTown", c => c.String());
            AlterColumn("dbo.Employees", "EmployeeMail", c => c.String());
            AlterColumn("dbo.Employees", "EmployeePhone", c => c.String());
            AlterColumn("dbo.Employees", "EmployeeSurName", c => c.String());
            AlterColumn("dbo.Employees", "EmployeeName", c => c.String());
            AlterColumn("dbo.Employees", "EmployeeTC", c => c.String());
        }
    }
}
