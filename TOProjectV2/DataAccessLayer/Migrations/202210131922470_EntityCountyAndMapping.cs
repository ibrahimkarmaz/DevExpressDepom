namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityCountyAndMapping : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countys",
                c => new
                    {
                        CountyID = c.Int(nullable: false, identity: true),
                        CityID = c.Int(nullable: false),
                        CountyName = c.String(maxLength: 60),
                        CityName = c.String(maxLength: 55),
                    })
                .PrimaryKey(t => t.CountyID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Countys");
        }
    }
}
