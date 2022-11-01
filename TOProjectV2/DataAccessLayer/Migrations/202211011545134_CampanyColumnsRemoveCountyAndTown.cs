namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampanyColumnsRemoveCountyAndTown : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Companies", "CompanyTown");
            DropColumn("dbo.Companies", "CompanyCounty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Companies", "CompanyCounty", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Companies", "CompanyTown", c => c.String(nullable: false, maxLength: 13));
        }
    }
}
