namespace Niagara_Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SubRoles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetSubRoles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubRole = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Document");
            DropTable("dbo.User");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        MiddleName = c.String(maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Type = c.String(nullable: false),
                        Subtype = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        City = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Document",
                c => new
                    {
                        documentID = c.String(nullable: false, maxLength: 128),
                        Type = c.String(nullable: false, maxLength: 50),
                        FileName = c.String(nullable: false, maxLength: 70),
                        Uploaded = c.DateTime(nullable: false),
                        UploadedBy = c.String(),
                        LastEdit = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.documentID);
            
            DropTable("dbo.AspNetSubRoles");
        }
    }
}
