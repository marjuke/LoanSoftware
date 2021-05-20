namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addotherbankcurrentsavingretentionproperty : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OtherBanks",
                c => new
                    {
                        OID = c.Int(nullable: false, identity: true),
                        LoanNo = c.String(),
                        NameofOtherBank = c.String(),
                        LoanAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExceptLoanDate = c.DateTime(nullable: false),
                        ExpireLoanDate = c.DateTime(nullable: false),
                        PresentLoanAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OID);
            
            CreateTable(
                "dbo.RetentionProperties",
                c => new
                    {
                        JID = c.Int(nullable: false, identity: true),
                        LoanNo = c.String(),
                        RetentionDescription = c.String(),
                        MoujaName = c.String(),
                        DocumentNo = c.String(),
                        LedgerNo = c.String(),
                        StainsNo = c.String(),
                        LandAmount = c.String(),
                        MinimumPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.JID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RetentionProperties");
            DropTable("dbo.OtherBanks");
        }
    }
}
