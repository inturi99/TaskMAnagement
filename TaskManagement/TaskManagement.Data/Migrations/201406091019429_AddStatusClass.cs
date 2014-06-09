namespace TaskManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        StatusName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 1000),
                        RowStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Status");
        }
    }
}
