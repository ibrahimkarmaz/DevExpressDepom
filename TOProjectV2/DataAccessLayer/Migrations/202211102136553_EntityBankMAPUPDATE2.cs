namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityBankMAPUPDATE2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Banks", "BankAccountNo", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.Banks", "BankAccountName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Banks", "BankAccountName", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Banks", "BankAccountNo");
        }
    }
}
