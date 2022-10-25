namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductNewColumnProductDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductDetails", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProductDetails");
        }
    }
}
