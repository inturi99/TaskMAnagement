namespace TaskManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPriorityClass : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Priorities");
            AlterColumn("dbo.Priorities", "ID", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.Priorities", "PriorityName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Priorities", "Description", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Priorities", "PriorityColor", c => c.String(nullable: false, maxLength: 10));
            AddPrimaryKey("dbo.Priorities", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Priorities");
            AlterColumn("dbo.Priorities", "PriorityColor", c => c.String());
            AlterColumn("dbo.Priorities", "Description", c => c.String());
            AlterColumn("dbo.Priorities", "PriorityName", c => c.String());
            AlterColumn("dbo.Priorities", "ID", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Priorities", "ID");
        }
    }
}
