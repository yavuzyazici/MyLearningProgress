namespace MyPortfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Messages", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Messages", "MessageText", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "MessageText", c => c.String());
            AlterColumn("dbo.Messages", "Email", c => c.String());
            AlterColumn("dbo.Messages", "Name", c => c.String());
        }
    }
}
