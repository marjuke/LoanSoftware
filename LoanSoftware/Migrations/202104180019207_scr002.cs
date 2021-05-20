namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scr002 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MemberLoanInfoes", "Amount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "DateofBirth", c => c.DateTime());
            AlterColumn("dbo.MemberLoanInfoes", "LoanRecoveryDays", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MemberLoanInfoes", "LoanRecoveryDays", c => c.Int(nullable: false));
            AlterColumn("dbo.MemberLoanInfoes", "DateofBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MemberLoanInfoes", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
