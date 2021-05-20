namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatememberloaninfo1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberLoanInfoes", "AccountNo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.MemberLoanInfoes", "AmmounInAccount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberLoanInfoes", "AmmounInAccount");
            DropColumn("dbo.MemberLoanInfoes", "AccountNo");
        }
    }
}
