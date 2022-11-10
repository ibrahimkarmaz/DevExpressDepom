namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityBankUPDATE1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Banks", "BankPhone", c => c.String(maxLength: 20));
            CreateIndex("dbo.Banks", "BankPhone", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Banks", new[] { "BankPhone" });
            DropColumn("dbo.Banks", "BankPhone");
        }
    }
}
