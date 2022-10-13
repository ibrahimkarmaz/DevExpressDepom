namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityDNeighborhoodAndMapping : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DNeighborhoods",
                c => new
                    {
                        DNeighborhoodID = c.Int(nullable: false, identity: true),
                        DNeighborhoodName1 = c.String(maxLength: 60),
                        DNeighborhoodName2 = c.String(maxLength: 55),
                        DNeighborhoodPostCode = c.Int(nullable: false),
                        CountyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DNeighborhoodID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DNeighborhoods");
        }
    }
}
