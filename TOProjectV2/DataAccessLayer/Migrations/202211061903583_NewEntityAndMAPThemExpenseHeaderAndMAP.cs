namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewEntityAndMAPThemExpenseHeaderAndMAP : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExorenseHeaders",
                c => new
                    {
                        ExorenseHeaderID = c.Int(nullable: false, identity: true),
                        ExorenseHeaderName = c.String(nullable: false, maxLength: 30),
                        ExorenseHeaderStartDate = c.DateTime(nullable: false),
                        ExorenseHeaderStopDate = c.DateTime(nullable: false),
                        ExpenseHeaderArchive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ExorenseHeaderID)
                .Index(t => t.ExorenseHeaderName, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.ExorenseHeaders", new[] { "ExorenseHeaderName" });
            DropTable("dbo.ExorenseHeaders");
        }
    }
}
