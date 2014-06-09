namespace TaskManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        ProjectName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 1000),
                        Key = c.String(nullable: false, maxLength: 6),
                        UserID = c.Guid(nullable: false),
                        CreateDateTime = c.DateTime(nullable: false),
                        UpdateDateTime = c.DateTime(nullable: false),
                        CreatedUserId = c.Guid(nullable: false),
                        UpdatedUserId = c.Guid(nullable: false),
                        RowStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 30),
                        ConformPasword = c.String(nullable: false, maxLength: 30),
                        FullName = c.String(nullable: false, maxLength: 100),
                        Gender = c.Int(nullable: false),
                        EmailId = c.String(nullable: false, maxLength: 50),
                        CreateDateTime = c.DateTime(nullable: false),
                        UpdateDateTime = c.DateTime(nullable: false),
                        CreatedUserId = c.Guid(nullable: false),
                        UpdatedUserId = c.Guid(nullable: false),
                        RowStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Description = c.String(maxLength: 1000),
                        RoleName = c.String(nullable: false, maxLength: 100),
                        CreateDateTime = c.DateTime(nullable: false),
                        UpdateDateTime = c.DateTime(nullable: false),
                        CreatedUserId = c.Guid(nullable: false),
                        UpdatedUserId = c.Guid(nullable: false),
                        RowStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "UserID", "dbo.Users");
            DropIndex("dbo.Projects", new[] { "UserID" });
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Projects");
        }
    }
}
