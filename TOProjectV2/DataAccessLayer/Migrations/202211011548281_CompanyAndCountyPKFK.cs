namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyAndCountyPKFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "CountyID", c => c.Int(nullable: false));
            CreateIndex("dbo.Companies", "CountyID");
            AddForeignKey("dbo.Companies", "CountyID", "dbo.Countys", "CountyID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "CountyID", "dbo.Countys");
            DropIndex("dbo.Companies", new[] { "CountyID" });
            DropColumn("dbo.Companies", "CountyID");
        }
    }
}
