namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Data.SqlClient;

    public partial class CustomerAndDistrictPKFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DistrictID", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "DistrictID");
            AddForeignKey("dbo.Customers", "DistrictID", "dbo.Districts", "DistrictID", cascadeDelete: false);
            DropColumn("dbo.Customers", "CustomerTown");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerTown", c => c.String(nullable: false, maxLength: 13));
            DropForeignKey("dbo.Customers", "DistrictID", "dbo.Districts");
            DropIndex("dbo.Customers", new[] { "DistrictID" });
            DropColumn("dbo.Customers", "DistrictID");
        }
    }
}
