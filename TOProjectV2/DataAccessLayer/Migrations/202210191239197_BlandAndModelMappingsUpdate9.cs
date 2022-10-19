namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlandAndModelMappingsUpdate9 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Models", new[] { "ModelYear" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Models", "ModelYear", unique: true);
        }
    }
}
