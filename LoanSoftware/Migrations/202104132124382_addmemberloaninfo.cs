namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmemberloaninfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberLoanInfoes",
                c => new
                    {
                        MID = c.Int(nullable: false, identity: true),
                        ApprovalNo = c.String(),
                        Date = c.DateTime(nullable: false),
                        MemberNo = c.String(),
                        ShareNumber = c.String(),
                        ShareAmount = c.String(),
                        RecentCalculationNo = c.String(),
                        InvestmentNo = c.String(),
                        AplicantName = c.String(),
                        DateofBirth = c.DateTime(nullable: false),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        NID = c.String(),
                        Village = c.String(),
                        PO = c.String(),
                        PS = c.String(),
                        District = c.String(),
                        PresentAddress = c.String(),
                        BusinessAddress = c.String(),
                        PhoneNumber = c.String(),
                        MobileNumber = c.String(),
                        Email = c.String(),
                        BusinessNature = c.String(),
                        BusinessType = c.String(),
                        MotiveofLoan = c.String(),
                        DateOwn = c.DateTime(nullable: false),
                        DateRent = c.String(),
                        AmountRent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NameRent = c.String(),
                        StockAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OwnAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MLFile = c.String(),
                    })
                .PrimaryKey(t => t.MID);
            
            DropTable("dbo.LoanInfoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LoanInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.MemberLoanInfoes");
        }
    }
}
