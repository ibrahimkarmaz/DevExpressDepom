namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityBankQueUPDATE : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Banks", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.Banks", "CountyID", "dbo.Countys");
            DropForeignKey("dbo.Banks", "DistrictID", "dbo.Districts");
            DropIndex("dbo.Banks", new[] { "CountyID" });
            DropIndex("dbo.Banks", new[] { "DistrictID" });
            DropIndex("dbo.Banks", new[] { "CompanyID" });
            AlterColumn("dbo.Banks", "CountyID", c => c.Int());
            AlterColumn("dbo.Banks", "DistrictID", c => c.Int());
            AlterColumn("dbo.Banks", "CompanyID", c => c.Int());
            CreateIndex("dbo.Banks", "CountyID");
            CreateIndex("dbo.Banks", "DistrictID");
            CreateIndex("dbo.Banks", "CompanyID");
            AddForeignKey("dbo.Banks", "CompanyID", "dbo.Companies", "CompanyID");
            AddForeignKey("dbo.Banks", "CountyID", "dbo.Countys", "CountyID");
            AddForeignKey("dbo.Banks", "DistrictID", "dbo.Districts", "DistrictID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Banks", "DistrictID", "dbo.Districts");
            DropForeignKey("dbo.Banks", "CountyID", "dbo.Countys");
            DropForeignKey("dbo.Banks", "CompanyID", "dbo.Companies");
            DropIndex("dbo.Banks", new[] { "CompanyID" });
            DropIndex("dbo.Banks", new[] { "DistrictID" });
            DropIndex("dbo.Banks", new[] { "CountyID" });
            AlterColumn("dbo.Banks", "CompanyID", c => c.Int(nullable: false));
            AlterColumn("dbo.Banks", "DistrictID", c => c.Int(nullable: false));
            AlterColumn("dbo.Banks", "CountyID", c => c.Int(nullable: false));
            CreateIndex("dbo.Banks", "CompanyID");
            CreateIndex("dbo.Banks", "DistrictID");
            CreateIndex("dbo.Banks", "CountyID");
            AddForeignKey("dbo.Banks", "DistrictID", "dbo.Districts", "DistrictID", cascadeDelete: true);
            AddForeignKey("dbo.Banks", "CountyID", "dbo.Countys", "CountyID", cascadeDelete: true);
            AddForeignKey("dbo.Banks", "CompanyID", "dbo.Companies", "CompanyID", cascadeDelete: true);
        }
    }
}
