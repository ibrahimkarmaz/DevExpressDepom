namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityBankAndCountyPKFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Banks", "CountyID", c => c.Int(nullable: false));
            CreateIndex("dbo.Banks", "CountyID");
            AddForeignKey("dbo.Banks", "CountyID", "dbo.Countys", "CountyID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Banks", "CountyID", "dbo.Countys");
            DropIndex("dbo.Banks", new[] { "CountyID" });
            DropColumn("dbo.Banks", "CountyID");
        }
    }
}
