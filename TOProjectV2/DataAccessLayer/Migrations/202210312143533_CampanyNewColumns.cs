namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampanyNewColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "CompanyOfficialTC", c => c.String());
            AddColumn("dbo.Companies", "CompanySpecialCode1", c => c.String());
            AddColumn("dbo.Companies", "CompanySpecialCode2", c => c.String());
            AddColumn("dbo.Companies", "CompanySpecialCode3", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "CompanySpecialCode3");
            DropColumn("dbo.Companies", "CompanySpecialCode2");
            DropColumn("dbo.Companies", "CompanySpecialCode1");
            DropColumn("dbo.Companies", "CompanyOfficialTC");
        }
    }
}
