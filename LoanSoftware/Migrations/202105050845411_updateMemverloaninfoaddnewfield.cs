namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMemverloaninfoaddnewfield : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberLoanInfoes", "LoanType", c => c.String());
            AddColumn("dbo.MemberLoanInfoes", "LoanSubType", c => c.String());
            AddColumn("dbo.MemberLoanInfoes", "TRIBranchCode", c => c.String());
            AddColumn("dbo.MemberLoanInfoes", "TRIApplicantName", c => c.String());
            AddColumn("dbo.MemberLoanInfoes", "TRIMemberNo", c => c.String());
            AddColumn("dbo.MemberLoanInfoes", "TRILoanAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberLoanInfoes", "TRILoanAmount");
            DropColumn("dbo.MemberLoanInfoes", "TRIMemberNo");
            DropColumn("dbo.MemberLoanInfoes", "TRIApplicantName");
            DropColumn("dbo.MemberLoanInfoes", "TRIBranchCode");
            DropColumn("dbo.MemberLoanInfoes", "LoanSubType");
            DropColumn("dbo.MemberLoanInfoes", "LoanType");
        }
    }
}
