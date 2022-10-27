namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CountyUpdateColumnDelete : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Countys", "CityID");
            DropColumn("dbo.Countys", "CityName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countys", "CityName", c => c.String(maxLength: 55));
            AddColumn("dbo.Countys", "CityID", c => c.Int(nullable: false));
        }
    }
}
