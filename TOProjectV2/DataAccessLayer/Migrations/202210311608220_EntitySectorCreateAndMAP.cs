namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntitySectorCreateAndMAP : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sectors",
                c => new
                    {
                        SectorID = c.Int(nullable: false, identity: true),
                        SectorName = c.String(nullable: false, maxLength: 40),
                        SectorArchive = c.String(),
                    })
                .PrimaryKey(t => t.SectorID)
                .Index(t => t.SectorName, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Sectors", new[] { "SectorName" });
            DropTable("dbo.Sectors");
        }
    }
}
