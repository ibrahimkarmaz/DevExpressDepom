namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDis : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Districts", new[] { "DistrictName" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Districts", "DistrictName", unique: true);
        }
    }
}
