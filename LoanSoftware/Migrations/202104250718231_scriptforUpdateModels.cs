namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scriptforUpdateModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberLoanInfoes", "FieldNo", c => c.String());
            AddColumn("dbo.MemberLoanInfoes", "BiMudaraba_BIID", c => c.Int());
            AddColumn("dbo.MemberLoanInfoes", "CurrentSaving_CUID", c => c.Int());
            AddColumn("dbo.MemberLoanInfoes", "Guarantor_GID", c => c.Int());
            AddColumn("dbo.MemberLoanInfoes", "OtherBank_OID", c => c.Int());
            AddColumn("dbo.MemberLoanInfoes", "RetentionProperty_JID", c => c.Int());
            AddColumn("dbo.MemberLoanInfoes", "TRInvestment_TID", c => c.Int());
            AlterColumn("dbo.MemberLoanInfoes", "ApprovalNo", c => c.String(maxLength: 50));
            AlterColumn("dbo.MemberLoanInfoes", "MemberNo", c => c.String(maxLength: 50));
            AlterColumn("dbo.MemberLoanInfoes", "ShareNumber", c => c.String(maxLength: 50));
            AlterColumn("dbo.MemberLoanInfoes", "ShareAmount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.MemberLoanInfoes", "Village", c => c.String(maxLength: 50));
            AlterColumn("dbo.MemberLoanInfoes", "PO", c => c.String(maxLength: 50));
            AlterColumn("dbo.MemberLoanInfoes", "PS", c => c.String(maxLength: 50));
            AlterColumn("dbo.MemberLoanInfoes", "District", c => c.String(maxLength: 50));
            AlterColumn("dbo.MemberLoanInfoes", "PresentAddress", c => c.String(maxLength: 50));
            AlterColumn("dbo.MemberLoanInfoes", "BusinessAddress", c => c.String(maxLength: 50));
            AlterColumn("dbo.MemberLoanInfoes", "PhoneNumber", c => c.String(maxLength: 50));
            AlterColumn("dbo.MemberLoanInfoes", "MobileNumber", c => c.String(maxLength: 50));
            AlterColumn("dbo.MemberLoanInfoes", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.MemberLoanInfoes", "BusinessNature", c => c.String(maxLength: 50));
            AlterColumn("dbo.MemberLoanInfoes", "BusinessType", c => c.String(maxLength: 50));
            AlterColumn("dbo.MemberLoanInfoes", "MotiveofLoan", c => c.String(maxLength: 200));
            AlterColumn("dbo.MemberLoanInfoes", "DateRent", c => c.DateTime());
            AlterColumn("dbo.MemberLoanInfoes", "NameRent", c => c.String(maxLength: 100));
            CreateIndex("dbo.MemberLoanInfoes", "BiMudaraba_BIID");
            CreateIndex("dbo.MemberLoanInfoes", "CurrentSaving_CUID");
            CreateIndex("dbo.MemberLoanInfoes", "Guarantor_GID");
            CreateIndex("dbo.MemberLoanInfoes", "OtherBank_OID");
            CreateIndex("dbo.MemberLoanInfoes", "RetentionProperty_JID");
            CreateIndex("dbo.MemberLoanInfoes", "TRInvestment_TID");
            AddForeignKey("dbo.MemberLoanInfoes", "BiMudaraba_BIID", "dbo.BiMudarabas", "BIID");
            AddForeignKey("dbo.MemberLoanInfoes", "CurrentSaving_CUID", "dbo.CurrentSavings", "CUID");
            AddForeignKey("dbo.MemberLoanInfoes", "Guarantor_GID", "dbo.Guarantors", "GID");
            AddForeignKey("dbo.MemberLoanInfoes", "OtherBank_OID", "dbo.OtherBanks", "OID");
            AddForeignKey("dbo.MemberLoanInfoes", "RetentionProperty_JID", "dbo.RetentionProperties", "JID");
            AddForeignKey("dbo.MemberLoanInfoes", "TRInvestment_TID", "dbo.TRInvestments", "TID");
            DropColumn("dbo.MemberLoanInfoes", "RecentCalculationNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberLoanInfoes", "RecentCalculationNo", c => c.String());
            DropForeignKey("dbo.MemberLoanInfoes", "TRInvestment_TID", "dbo.TRInvestments");
            DropForeignKey("dbo.MemberLoanInfoes", "RetentionProperty_JID", "dbo.RetentionProperties");
            DropForeignKey("dbo.MemberLoanInfoes", "OtherBank_OID", "dbo.OtherBanks");
            DropForeignKey("dbo.MemberLoanInfoes", "Guarantor_GID", "dbo.Guarantors");
            DropForeignKey("dbo.MemberLoanInfoes", "CurrentSaving_CUID", "dbo.CurrentSavings");
            DropForeignKey("dbo.MemberLoanInfoes", "BiMudaraba_BIID", "dbo.BiMudarabas");
            DropIndex("dbo.MemberLoanInfoes", new[] { "TRInvestment_TID" });
            DropIndex("dbo.MemberLoanInfoes", new[] { "RetentionProperty_JID" });
            DropIndex("dbo.MemberLoanInfoes", new[] { "OtherBank_OID" });
            DropIndex("dbo.MemberLoanInfoes", new[] { "Guarantor_GID" });
            DropIndex("dbo.MemberLoanInfoes", new[] { "CurrentSaving_CUID" });
            DropIndex("dbo.MemberLoanInfoes", new[] { "BiMudaraba_BIID" });
            AlterColumn("dbo.MemberLoanInfoes", "NameRent", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "DateRent", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "MotiveofLoan", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "BusinessType", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "BusinessNature", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "Email", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "MobileNumber", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "PhoneNumber", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "BusinessAddress", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "PresentAddress", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "District", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "PS", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "PO", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "Village", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "ShareAmount", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "ShareNumber", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "MemberNo", c => c.String());
            AlterColumn("dbo.MemberLoanInfoes", "ApprovalNo", c => c.String());
            DropColumn("dbo.MemberLoanInfoes", "TRInvestment_TID");
            DropColumn("dbo.MemberLoanInfoes", "RetentionProperty_JID");
            DropColumn("dbo.MemberLoanInfoes", "OtherBank_OID");
            DropColumn("dbo.MemberLoanInfoes", "Guarantor_GID");
            DropColumn("dbo.MemberLoanInfoes", "CurrentSaving_CUID");
            DropColumn("dbo.MemberLoanInfoes", "BiMudaraba_BIID");
            DropColumn("dbo.MemberLoanInfoes", "FieldNo");
        }
    }
}
