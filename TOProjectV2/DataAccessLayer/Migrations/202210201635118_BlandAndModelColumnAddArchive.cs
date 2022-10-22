namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlandAndModelColumnAddArchive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blands", "BlandArchive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Models", "ModelArchive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Models", "ModelArchive");
            DropColumn("dbo.Blands", "BlandArchive");
        }
    }
}
