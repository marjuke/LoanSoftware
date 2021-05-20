namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateToStringMAccountNoinMemberLoanInfos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MemberLoanInfoes", "MAccountNo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MemberLoanInfoes", "MAccountNo", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
