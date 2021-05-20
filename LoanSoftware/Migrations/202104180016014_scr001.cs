namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scr001 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MemberLoanInfoes", "AmountRent", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "OwnAmount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "MonthlyAvarageIncome", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "DailySaleAmount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "DailyProfit", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "DailyIncome", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "MonthlySaleAmount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "MonthlyProfit", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "MonthlyIncome", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "MAccountNo", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "AmountInAccount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "LoanAmountTotal", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "LoanInstallmentAmount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "LoanProvideDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MemberLoanInfoes", "LoanProvideDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MemberLoanInfoes", "LoanInstallmentAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "LoanAmountTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "AmountInAccount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "MAccountNo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "MonthlyIncome", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "MonthlyProfit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "MonthlySaleAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "DailyIncome", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "DailyProfit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "DailySaleAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "MonthlyAvarageIncome", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "OwnAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "AmountRent", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
