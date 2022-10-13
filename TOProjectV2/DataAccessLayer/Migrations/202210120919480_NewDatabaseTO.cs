namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDatabaseTO : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeTC = c.String(),
                        EmployeeName = c.String(),
                        EmployeeSurName = c.String(),
                        EmployeePhone = c.String(),
                        EmployeeMail = c.String(),
                        EmployeeTown = c.String(),
                        EmployeeCounty = c.String(),
                        EmployeeHomeAddress = c.String(),
                        EmployeeTask = c.String(),
                        EmployeeArchive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
