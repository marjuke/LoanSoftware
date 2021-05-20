namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFormStatusTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FormStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FormID = c.Int(nullable: false),
                        ApprovedDate = c.DateTime(nullable: false),
                        ApprovedUser = c.String(),
                        ApprovedBranchCode = c.String(maxLength: 128),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.ApprovedBranchCode)
                .ForeignKey("dbo.MemberLoanInfoes", t => t.FormID)
                .Index(t => t.ApprovedBranchCode)
                .Index(t => t.FormID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FormStatus", "FormID", "dbo.MemberLoanInfoes");
            DropForeignKey("dbo.FormStatus", "ApprovedBranchCode", "dbo.Branches");
            DropIndex("dbo.FormStatus", new[] { "FormID" });
            DropIndex("dbo.FormStatus", new[] { "ApprovedBranchCode" });
            DropTable("dbo.FormStatus");
        }
    }
}
