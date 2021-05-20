namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BranchCode : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchCode = c.String(nullable: false, maxLength: 128),
                        OppeningDate = c.DateTime(),
                        ZoneCode = c.String(),
                        BranchName = c.String(),
                        BrManager = c.String(),
                        Comments = c.String(),
                        Mobile = c.String(),
                        Phone = c.String(),
                        EMail = c.String(),
                    })
                .PrimaryKey(t => t.BranchCode);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Branches");
        }
    }
}
