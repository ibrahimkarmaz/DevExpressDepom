namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityBankAndMappign : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        BankID = c.Int(nullable: false, identity: true),
                        BankName = c.String(nullable: false),
                        BankBranch = c.String(maxLength: 30),
                        IBAN = c.String(nullable: false, maxLength: 30),
                        BankAccountName = c.String(nullable: false, maxLength: 20),
                        BankOfficial = c.String(nullable: false, maxLength: 30),
                        BankDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        BankAccountType = c.String(nullable: false, maxLength: 20),
                        BankArchive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BankID)
                .Index(t => t.IBAN, unique: true)
                .Index(t => t.BankAccountName, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Banks", new[] { "BankAccountName" });
            DropIndex("dbo.Banks", new[] { "IBAN" });
            DropTable("dbo.Banks");
        }
    }
}
