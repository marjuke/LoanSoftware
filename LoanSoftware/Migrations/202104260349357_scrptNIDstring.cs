namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scrptNIDstring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MemberLoanInfoes", "NID", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MemberLoanInfoes", "NID", c => c.Int(nullable: false));
        }
    }
}
