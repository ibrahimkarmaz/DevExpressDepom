namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyMovementColumnTypeUPDATE : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CompanyMovements", "CompanyMovemenArchive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CompanyMovements", "CompanyMovemenArchive", c => c.Int(nullable: false));
        }
    }
}
