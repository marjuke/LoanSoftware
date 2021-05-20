namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BranchLimit1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Branches", "BranchLimit_LimitID", "dbo.BranchLimits");
            DropIndex("dbo.Branches", new[] { "BranchLimit_LimitID" });
            DropColumn("dbo.Branches", "BranchLimit_LimitID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Branches", "BranchLimit_LimitID", c => c.Int());
            CreateIndex("dbo.Branches", "BranchLimit_LimitID");
            AddForeignKey("dbo.Branches", "BranchLimit_LimitID", "dbo.BranchLimits", "LimitID");
        }
    }
}
