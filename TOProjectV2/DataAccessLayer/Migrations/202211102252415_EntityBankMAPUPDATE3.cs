namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityBankMAPUPDATE3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Banks", new[] { "BankPhone" });
            AlterColumn("dbo.Banks", "BankPhone", c => c.String(maxLength: 15));
            CreateIndex("dbo.Banks", "BankPhone", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Banks", new[] { "BankPhone" });
            AlterColumn("dbo.Banks", "BankPhone", c => c.String(maxLength: 20));
            CreateIndex("dbo.Banks", "BankPhone", unique: true);
        }
    }
}
