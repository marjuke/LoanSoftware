namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BranchLimit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BranchLimits",
                c => new
                    {
                        LimitID = c.Int(nullable: false, identity: true),
                        BranchCode = c.String(),
                        BrLimit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.LimitID);
            
            AddColumn("dbo.Branches", "BranchLimit_LimitID", c => c.Int());
            CreateIndex("dbo.Branches", "BranchLimit_LimitID");
            AddForeignKey("dbo.Branches", "BranchLimit_LimitID", "dbo.BranchLimits", "LimitID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Branches", "BranchLimit_LimitID", "dbo.BranchLimits");
            DropIndex("dbo.Branches", new[] { "BranchLimit_LimitID" });
            DropColumn("dbo.Branches", "BranchLimit_LimitID");
            DropTable("dbo.BranchLimits");
        }
    }
}
