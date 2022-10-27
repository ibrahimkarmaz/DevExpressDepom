namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DisColumnEdit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        DistrictID = c.Int(nullable: false, identity: true),
                        DistrictName = c.String(),
                        CountyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DistrictID)
                .ForeignKey("dbo.Countys", t => t.CountyID, cascadeDelete: true)
                .Index(t => t.CountyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Districts", "CountyID", "dbo.Countys");
            DropIndex("dbo.Districts", new[] { "CountyID" });
            DropTable("dbo.Districts");
        }
    }
}
