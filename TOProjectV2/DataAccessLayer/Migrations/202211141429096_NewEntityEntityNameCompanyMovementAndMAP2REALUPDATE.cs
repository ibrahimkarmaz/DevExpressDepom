namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewEntityEntityNameCompanyMovementAndMAP2REALUPDATE : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompanyMovements",
                c => new
                    {
                        CompanyMovementID = c.Int(nullable: false, identity: true),
                        CompanyMovementDate = c.DateTime(nullable: false),
                        CompanyMovemenNote = c.String(maxLength: 250),
                        CompanyMovemenArchive = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyMovementID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CompanyMovements");
        }
    }
}
