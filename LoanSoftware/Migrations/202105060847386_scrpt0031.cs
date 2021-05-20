namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scrpt0031 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberLoanInfoes", "DailySavingType", c => c.String());
            AddColumn("dbo.MemberLoanInfoes", "DefalterBokeya", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.MemberLoanInfoes", "DefalterStithi", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.MemberLoanInfoes", "TRIBranchCode");
            DropColumn("dbo.MemberLoanInfoes", "TRIApplicantName");
            DropColumn("dbo.MemberLoanInfoes", "TRIMemberNo");
            DropColumn("dbo.MemberLoanInfoes", "TRILoanAmount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberLoanInfoes", "TRILoanAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.MemberLoanInfoes", "TRIMemberNo", c => c.String());
            AddColumn("dbo.MemberLoanInfoes", "TRIApplicantName", c => c.String());
            AddColumn("dbo.MemberLoanInfoes", "TRIBranchCode", c => c.String());
            DropColumn("dbo.MemberLoanInfoes", "DefalterStithi");
            DropColumn("dbo.MemberLoanInfoes", "DefalterBokeya");
            DropColumn("dbo.MemberLoanInfoes", "DailySavingType");
        }
    }
}
