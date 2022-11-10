namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityBankMAPUPDATE : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Banks", "BankName", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Banks", "BankName", c => c.String(nullable: false));
        }
    }
}
