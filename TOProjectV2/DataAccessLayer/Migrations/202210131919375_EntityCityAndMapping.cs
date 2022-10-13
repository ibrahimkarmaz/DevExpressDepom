namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityCityAndMapping : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Citys",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        CityName = c.String(maxLength: 20),
                        CityPlateNo = c.Int(nullable: false),
                        CityPhoneCode = c.Int(nullable: false),
                        CityRowNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Citys");
        }
    }
}
