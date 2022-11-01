namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveColumnsCampanyEntity : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Companies", "CompanySpecialCode1");
            DropColumn("dbo.Companies", "CompanySpecialCode2");
            DropColumn("dbo.Companies", "CompanySpecialCode3");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Companies", "CompanySpecialCode3", c => c.String(maxLength: 10));
            AddColumn("dbo.Companies", "CompanySpecialCode2", c => c.String(maxLength: 10));
            AddColumn("dbo.Companies", "CompanySpecialCode1", c => c.String(maxLength: 10));
        }
    }
}
