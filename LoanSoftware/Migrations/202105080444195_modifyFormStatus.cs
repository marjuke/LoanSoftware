namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyFormStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FormStatus", "ForwardDate", c => c.DateTime());
            AddColumn("dbo.FormStatus", "NotificationStatus", c => c.String());
            AlterColumn("dbo.FormStatus", "ApprovedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FormStatus", "ApprovedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.FormStatus", "NotificationStatus");
            DropColumn("dbo.FormStatus", "ForwardDate");
        }
    }
}
