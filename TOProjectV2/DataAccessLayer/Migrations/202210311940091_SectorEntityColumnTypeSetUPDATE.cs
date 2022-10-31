namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SectorEntityColumnTypeSetUPDATE : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sectors", "SectorArchive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sectors", "SectorArchive", c => c.String());
        }
    }
}
