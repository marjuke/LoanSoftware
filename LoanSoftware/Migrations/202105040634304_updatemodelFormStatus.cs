namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemodelFormStatus : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FormStatus", "FormID", "dbo.MemberLoanInfoes");
            DropIndex("dbo.FormStatus", new[] { "FormID" });
            DropColumn("dbo.FormStatus", "FormID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FormStatus", "FormID", c => c.Int());
            CreateIndex("dbo.FormStatus", "FormID");
            AddForeignKey("dbo.FormStatus", "FormID", "dbo.MemberLoanInfoes", "MID");
        }
    }
}
