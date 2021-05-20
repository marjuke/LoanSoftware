namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbranchcodeinIdentityModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BranchCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "BranchCode");
        }
    }
}
