namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateingmemberloaninfolast : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberLoanInfoes", "LoanInstallmentAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.MemberLoanInfoes", "LoanInstallment", c => c.String());
            DropColumn("dbo.MemberLoanInfoes", "InstallmentAmount");
            DropColumn("dbo.MemberLoanInfoes", "Installment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberLoanInfoes", "Installment", c => c.String());
            AddColumn("dbo.MemberLoanInfoes", "InstallmentAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.MemberLoanInfoes", "LoanInstallment");
            DropColumn("dbo.MemberLoanInfoes", "LoanInstallmentAmount");
        }
    }
}
