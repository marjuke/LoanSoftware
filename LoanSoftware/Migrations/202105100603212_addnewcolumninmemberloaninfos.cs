namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewcolumninmemberloaninfos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberLoanInfoes", "DailySaving", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.MemberLoanInfoes", "DailySavingYear", c => c.Int());
            AddColumn("dbo.MemberLoanInfoes", "shikkhabibahDuration", c => c.Int());
            AddColumn("dbo.MemberLoanInfoes", "MonthlySavingAmount", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.MemberLoanInfoes", "MonthlySavingAmountYear", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberLoanInfoes", "MonthlySavingAmountYear");
            DropColumn("dbo.MemberLoanInfoes", "MonthlySavingAmount");
            DropColumn("dbo.MemberLoanInfoes", "shikkhabibahDuration");
            DropColumn("dbo.MemberLoanInfoes", "DailySavingYear");
            DropColumn("dbo.MemberLoanInfoes", "DailySaving");
        }
    }
}
