namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerDateAndGenderQueryAdd2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "CountyID", "dbo.Countys");
            DropForeignKey("dbo.Customers", "DistrictID", "dbo.Districts");
            DropIndex("dbo.Customers", new[] { "CountyID" });
            DropIndex("dbo.Customers", new[] { "DistrictID" });
            AlterColumn("dbo.Customers", "CountyID", c => c.Int());
            AlterColumn("dbo.Customers", "DistrictID", c => c.Int());
            CreateIndex("dbo.Customers", "CountyID");
            CreateIndex("dbo.Customers", "DistrictID");
            AddForeignKey("dbo.Customers", "CountyID", "dbo.Countys", "CountyID");
            AddForeignKey("dbo.Customers", "DistrictID", "dbo.Districts", "DistrictID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "DistrictID", "dbo.Districts");
            DropForeignKey("dbo.Customers", "CountyID", "dbo.Countys");
            DropIndex("dbo.Customers", new[] { "DistrictID" });
            DropIndex("dbo.Customers", new[] { "CountyID" });
            AlterColumn("dbo.Customers", "DistrictID", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "CountyID", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "DistrictID");
            CreateIndex("dbo.Customers", "CountyID");
            AddForeignKey("dbo.Customers", "DistrictID", "dbo.Districts", "DistrictID", cascadeDelete: true);
            AddForeignKey("dbo.Customers", "CountyID", "dbo.Countys", "CountyID", cascadeDelete: true);
        }
    }
}
