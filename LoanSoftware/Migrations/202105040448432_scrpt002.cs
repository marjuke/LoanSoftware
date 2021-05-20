namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scrpt002 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BiMudarabas", "FormID", c => c.Int(nullable: false));
            AddColumn("dbo.MemberLoanInfoes", "FormID", c => c.Int(nullable: false));
            AddColumn("dbo.CurrentSavings", "FormID", c => c.Int(nullable: false));
            AddColumn("dbo.Guarantors", "FormID", c => c.Int(nullable: false));
            AddColumn("dbo.OtherBanks", "FormID", c => c.Int(nullable: false));
            AddColumn("dbo.RetentionProperties", "FormID", c => c.Int(nullable: false));
            AddColumn("dbo.TRInvestments", "FormID", c => c.Int(nullable: false));
            DropColumn("dbo.BiMudarabas", "FromID");
            DropColumn("dbo.MemberLoanInfoes", "FromID");
            DropColumn("dbo.CurrentSavings", "FromID");
            DropColumn("dbo.Guarantors", "FromID");
            DropColumn("dbo.OtherBanks", "FromID");
            DropColumn("dbo.RetentionProperties", "FromID");
            DropColumn("dbo.TRInvestments", "FromID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TRInvestments", "FromID", c => c.Int(nullable: false));
            AddColumn("dbo.RetentionProperties", "FromID", c => c.Int(nullable: false));
            AddColumn("dbo.OtherBanks", "FromID", c => c.Int(nullable: false));
            AddColumn("dbo.Guarantors", "FromID", c => c.Int(nullable: false));
            AddColumn("dbo.CurrentSavings", "FromID", c => c.Int(nullable: false));
            AddColumn("dbo.MemberLoanInfoes", "FromID", c => c.Int(nullable: false));
            AddColumn("dbo.BiMudarabas", "FromID", c => c.Int(nullable: false));
            DropColumn("dbo.TRInvestments", "FormID");
            DropColumn("dbo.RetentionProperties", "FormID");
            DropColumn("dbo.OtherBanks", "FormID");
            DropColumn("dbo.Guarantors", "FormID");
            DropColumn("dbo.CurrentSavings", "FormID");
            DropColumn("dbo.MemberLoanInfoes", "FormID");
            DropColumn("dbo.BiMudarabas", "FormID");
        }
    }
}
