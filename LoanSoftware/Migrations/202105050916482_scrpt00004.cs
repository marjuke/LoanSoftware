namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scrpt00004 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberLoanInfoes", "LoanInstallmentType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberLoanInfoes", "LoanInstallmentType");
        }
    }
}
