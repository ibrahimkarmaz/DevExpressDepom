namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewEntityDepartmenAndMap : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(nullable: false, maxLength: 20),
                        DepartmentArchive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentID)
                .Index(t => t.DepartmentName, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Departments", new[] { "DepartmentName" });
            DropTable("dbo.Departments");
        }
    }
}
