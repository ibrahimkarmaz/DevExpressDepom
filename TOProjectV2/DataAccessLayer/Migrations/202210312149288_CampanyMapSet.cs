namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampanyMapSet : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "CompanyOfficialTC", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Companies", "CompanySpecialCode1", c => c.String(maxLength: 10));
            AlterColumn("dbo.Companies", "CompanySpecialCode2", c => c.String(maxLength: 10));
            AlterColumn("dbo.Companies", "CompanySpecialCode3", c => c.String(maxLength: 10));
            CreateIndex("dbo.Companies", "CompanyOfficialTC", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Companies", new[] { "CompanyOfficialTC" });
            AlterColumn("dbo.Companies", "CompanySpecialCode3", c => c.String());
            AlterColumn("dbo.Companies", "CompanySpecialCode2", c => c.String());
            AlterColumn("dbo.Companies", "CompanySpecialCode1", c => c.String());
            AlterColumn("dbo.Companies", "CompanyOfficialTC", c => c.String());
        }
    }
}
