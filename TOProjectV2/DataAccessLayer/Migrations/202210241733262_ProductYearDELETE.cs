namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductYearDELETE : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "ProductYear");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProductYear", c => c.String(nullable: false, maxLength: 4, fixedLength: true, unicode: false));
        }
    }
}
