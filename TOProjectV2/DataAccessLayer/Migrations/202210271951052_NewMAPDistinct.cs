namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMAPDistinct : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Districts", "DistrictName", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Districts", "DistrictName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Districts", new[] { "DistrictName" });
            AlterColumn("dbo.Districts", "DistrictName", c => c.String());
        }
    }
}
