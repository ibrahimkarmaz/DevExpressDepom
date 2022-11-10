namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityBankAndDistrictPKFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Banks", "DistrictID", c => c.Int(nullable: false));
            CreateIndex("dbo.Banks", "DistrictID");
            AddForeignKey("dbo.Banks", "DistrictID", "dbo.Districts", "DistrictID", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Banks", "DistrictID", "dbo.Districts");
            DropIndex("dbo.Banks", new[] { "DistrictID" });
            DropColumn("dbo.Banks", "DistrictID");
        }
    }
}
