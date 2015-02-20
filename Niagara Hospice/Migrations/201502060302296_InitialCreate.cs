namespace Niagara_Hospice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        ClientID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        MiddleName = c.String(),
                        LastName = c.String(nullable: false, maxLength: 50),
                        DOB = c.DateTime(),
                        Phone = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 50),
                        City = c.String(nullable: false, maxLength: 50),
                        Status = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ClientID);
            
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
            
            CreateTable(
                "dbo.Meeting",
                c => new
                    {
                        MeetingID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Location = c.String(),
                        Type = c.String(),
                        Description = c.String(),
                        Requirements = c.String(),
                        Lead = c.String(),
                    })
                .PrimaryKey(t => t.MeetingID);
            
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
            DropTable("dbo.Meeting");
            DropTable("dbo.Document");
            DropTable("dbo.Client");
        }
    }
}
