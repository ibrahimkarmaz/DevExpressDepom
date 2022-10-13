namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityNoteAndMapping : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        NoteID = c.Int(nullable: false, identity: true),
                        NoteDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        NoteHour = c.DateTime(nullable: false),
                        NoteTitle = c.String(nullable: false, maxLength: 50),
                        NoteDetail = c.String(nullable: false, maxLength: 250),
                        NoteCreate = c.String(nullable: false, maxLength: 40),
                        NoteArchive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.NoteID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Notes");
        }
    }
}
