namespace TaskManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIssueTypeClass : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.IssueTypes");
            AlterColumn("dbo.IssueTypes", "ID", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.IssueTypes", "IssueTypeName", c => c.String(nullable: false, maxLength: 100));
            AddPrimaryKey("dbo.IssueTypes", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.IssueTypes");
            AlterColumn("dbo.IssueTypes", "IssueTypeName", c => c.String());
            AlterColumn("dbo.IssueTypes", "ID", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.IssueTypes", "ID");
        }
    }
}
