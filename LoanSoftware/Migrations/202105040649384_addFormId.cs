namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFormId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FormStatus", "FormID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FormStatus", "FormID");
        }
    }
}
