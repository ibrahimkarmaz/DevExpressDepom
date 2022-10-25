namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductModelPKFKUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ModelID", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "ModelID");
            AddForeignKey("dbo.Products", "ModelID", "dbo.Models", "ModelID", cascadeDelete: false);//NOT DELETE İŞLEMİNİ FALSE ÇEKİLDİ HATA VERDİĞİ İÇİN.
            DropColumn("dbo.Products", "ProductModel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProductModel", c => c.String(nullable: false, maxLength: 20));
            DropForeignKey("dbo.Products", "ModelID", "dbo.Models");
            DropIndex("dbo.Products", new[] { "ModelID" });
            DropColumn("dbo.Products", "ModelID");
        }
    }
}
