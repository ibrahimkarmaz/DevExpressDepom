namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerAndCountyPKFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CountyID", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "CountyID");
            AddForeignKey("dbo.Customers", "CountyID", "dbo.Countys", "CountyID", cascadeDelete: true);
            DropColumn("dbo.Customers", "CustomerCounty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerCounty", c => c.String(nullable: false, maxLength: 20));
            DropForeignKey("dbo.Customers", "CountyID", "dbo.Countys");
            DropIndex("dbo.Customers", new[] { "CountyID" });
            DropColumn("dbo.Customers", "CountyID");
        }
    }
}
