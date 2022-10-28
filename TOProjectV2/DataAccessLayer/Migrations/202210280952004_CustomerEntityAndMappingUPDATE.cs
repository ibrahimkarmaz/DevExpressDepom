namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerEntityAndMappingUPDATE : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "CustomerOfficePhone" });
            DropIndex("dbo.Customers", new[] { "CustomerTaxNumber" });
            AddColumn("dbo.Customers", "CustomerGender", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "CustomerDateOfBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerDateOfBirth");
            DropColumn("dbo.Customers", "CustomerGender");
            CreateIndex("dbo.Customers", "CustomerTaxNumber", unique: true);
            CreateIndex("dbo.Customers", "CustomerOfficePhone", unique: true);
        }
    }
}
