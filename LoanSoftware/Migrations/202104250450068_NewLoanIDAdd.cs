namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewLoanIDAdd : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.MemberLoanInfoes");
            AddColumn("dbo.BiMudarabas", "FormID", c => c.Int(nullable: false));
            AddColumn("dbo.CurrentSavings", "FormID", c => c.Int(nullable: false));
            AddColumn("dbo.Guarantors", "FormID", c => c.Int(nullable: false));
            AddColumn("dbo.MemberLoanInfoes", "FormID", c => c.Int(nullable: false));
            AddColumn("dbo.MemberLoanInfoes", "SoftwareLoanNo", c => c.String());
            AddColumn("dbo.OtherBanks", "FormID", c => c.Int(nullable: false));
            AddColumn("dbo.RetentionProperties", "FormID", c => c.Int(nullable: false));
            AddColumn("dbo.TRInvestments", "FormID", c => c.Int(nullable: false));
            AlterColumn("dbo.MemberLoanInfoes", "MID", c => c.Int(nullable: false));
            AlterColumn("dbo.MemberLoanInfoes", "NID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.MemberLoanInfoes", new[] { "MID", "FormID" });
            DropColumn("dbo.BiMudarabas", "LoanNo");
            DropColumn("dbo.CurrentSavings", "LoanNo");
            DropColumn("dbo.Guarantors", "LoanNo");
            DropColumn("dbo.OtherBanks", "LoanNo");
            DropColumn("dbo.RetentionProperties", "LoanNo");
            DropColumn("dbo.TRInvestments", "LoanNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TRInvestments", "LoanNo", c => c.String());
            AddColumn("dbo.RetentionProperties", "LoanNo", c => c.String());
            AddColumn("dbo.OtherBanks", "LoanNo", c => c.String());
            AddColumn("dbo.Guarantors", "LoanNo", c => c.String());
            AddColumn("dbo.CurrentSavings", "LoanNo", c => c.String(nullable: false));
            AddColumn("dbo.BiMudarabas", "LoanNo", c => c.String(nullable: false, maxLength: 50));
            DropPrimaryKey("dbo.MemberLoanInfoes");
            AlterColumn("dbo.MemberLoanInfoes", "NID", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "MID", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.TRInvestments", "FormID");
            DropColumn("dbo.RetentionProperties", "FormID");
            DropColumn("dbo.OtherBanks", "FormID");
            DropColumn("dbo.MemberLoanInfoes", "SoftwareLoanNo");
            DropColumn("dbo.MemberLoanInfoes", "FormID");
            DropColumn("dbo.Guarantors", "FormID");
            DropColumn("dbo.CurrentSavings", "FormID");
            DropColumn("dbo.BiMudarabas", "FormID");
            AddPrimaryKey("dbo.MemberLoanInfoes", "MID");
        }
    }
}
