namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityStockAndMapping : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StockID = c.Int(nullable: false, identity: true),
                        StockType = c.String(nullable: false, maxLength: 20),
                        StockPiece = c.String(nullable: false),
                        StockArchive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StockID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stocks");
        }
    }
}
