namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatememberloaninfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberLoanInfoes", "LoanNo", c => c.String());
            AddColumn("dbo.MemberLoanInfoes", "BranchCode", c => c.String());
            AddColumn("dbo.MemberLoanInfoes", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.MemberLoanInfoes", "LastDate", c => c.DateTime());
            AddColumn("dbo.MemberLoanInfoes", "MonthlyAvarageIncome", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.MemberLoanInfoes", "DailySaleAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.MemberLoanInfoes", "DailyProfit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.MemberLoanInfoes", "DailyIncome", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.MemberLoanInfoes", "MonthlySaleAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.MemberLoanInfoes", "MonthlyProfit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.MemberLoanInfoes", "MonthlyIncome", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "Date", c => c.DateTime());
            AlterColumn("dbo.MemberLoanInfoes", "DateOwn", c => c.DateTime());
            DropColumn("dbo.MemberLoanInfoes", "StockAmount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberLoanInfoes", "StockAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "DateOwn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MemberLoanInfoes", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.MemberLoanInfoes", "MonthlyIncome");
            DropColumn("dbo.MemberLoanInfoes", "MonthlyProfit");
            DropColumn("dbo.MemberLoanInfoes", "MonthlySaleAmount");
            DropColumn("dbo.MemberLoanInfoes", "DailyIncome");
            DropColumn("dbo.MemberLoanInfoes", "DailyProfit");
            DropColumn("dbo.MemberLoanInfoes", "DailySaleAmount");
            DropColumn("dbo.MemberLoanInfoes", "MonthlyAvarageIncome");
            DropColumn("dbo.MemberLoanInfoes", "LastDate");
            DropColumn("dbo.MemberLoanInfoes", "Amount");
            DropColumn("dbo.MemberLoanInfoes", "BranchCode");
            DropColumn("dbo.MemberLoanInfoes", "LoanNo");
        }
    }
}
