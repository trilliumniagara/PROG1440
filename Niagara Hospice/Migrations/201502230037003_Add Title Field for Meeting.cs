namespace Niagara_Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTitleFieldforMeeting : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Meeting", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Meeting", "Title");
        }
    }
}
