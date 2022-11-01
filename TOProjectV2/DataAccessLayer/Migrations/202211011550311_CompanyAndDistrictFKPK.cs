namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyAndDistrictFKPK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "DistrictID", c => c.Int(nullable: false));
            CreateIndex("dbo.Companies", "DistrictID");
            AddForeignKey("dbo.Companies", "DistrictID", "dbo.Districts", "DistrictID", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "DistrictID", "dbo.Districts");
            DropIndex("dbo.Companies", new[] { "DistrictID" });
            DropColumn("dbo.Companies", "DistrictID");
        }
    }
}
