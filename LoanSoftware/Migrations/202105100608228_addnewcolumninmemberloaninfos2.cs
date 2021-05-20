namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewcolumninmemberloaninfos2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberLoanInfoes", "DailySaving2", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberLoanInfoes", "DailySaving2");
        }
    }
}
