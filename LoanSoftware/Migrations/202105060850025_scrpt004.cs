namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scrpt004 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MemberLoanInfoes", "DefalterBokeya", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "DefalterStithi", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MemberLoanInfoes", "DefalterStithi", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "DefalterBokeya", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
