namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatememberLoanlast : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.MemberLoanInfoes");
            AlterColumn("dbo.MemberLoanInfoes", "MID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.MemberLoanInfoes", "MID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.MemberLoanInfoes");
            AlterColumn("dbo.MemberLoanInfoes", "MID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.MemberLoanInfoes", new[] { "MID", "FormID" });
        }
    }
}
