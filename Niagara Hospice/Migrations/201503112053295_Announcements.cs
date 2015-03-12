namespace Niagara_Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Announcements : DbMigration
    {
        public override void Up()
        {
            CreateTable
                "dbo.Announcements",
                c => new
                    {
                        AnnouncementID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        PostDate = c.DateTime(nullable: false),
                        AnnouncementType = c.String(nullable: false),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.AnnouncementID);
            
            AlterColumn("dbo.Meeting", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Meeting", "Location", c => c.String(nullable: false));
            AlterColumn("dbo.Meeting", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Meeting", "Description", c => c.String());
            AlterColumn("dbo.Meeting", "Location", c => c.String());
            AlterColumn("dbo.Meeting", "Title", c => c.String());
            DropTable("dbo.Announcements");
        }
    }
}
