namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyAndSectorPKFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "SectorID", c => c.Int(nullable: false));
            CreateIndex("dbo.Companies", "SectorID");
            AddForeignKey("dbo.Companies", "SectorID", "dbo.Sectors", "SectorID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "SectorID", "dbo.Sectors");
            DropIndex("dbo.Companies", new[] { "SectorID" });
            DropColumn("dbo.Companies", "SectorID");
        }
    }
}
