namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatememberloaninfo2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberLoanInfoes", "MAccountNo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.MemberLoanInfoes", "AmountInAccount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.MemberLoanInfoes", "AccountNo");
            DropColumn("dbo.MemberLoanInfoes", "AmmounInAccount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberLoanInfoes", "AmmounInAccount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.MemberLoanInfoes", "AccountNo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.MemberLoanInfoes", "AmountInAccount");
            DropColumn("dbo.MemberLoanInfoes", "MAccountNo");
        }
    }
}
