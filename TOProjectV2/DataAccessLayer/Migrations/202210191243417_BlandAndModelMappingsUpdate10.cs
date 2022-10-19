namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlandAndModelMappingsUpdate10 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Models", new[] { "ModelName" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Models", "ModelName", unique: true);
        }
    }
}
