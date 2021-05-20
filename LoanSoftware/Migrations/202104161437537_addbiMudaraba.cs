namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbiMudaraba : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BiMudarabas",
                c => new
                    {
                        BIID = c.Int(nullable: false, identity: true),
                        LoanNo = c.String(nullable: false, maxLength: 50),
                        TypeofInvestment = c.String(maxLength: 30),
                        DescriptionofInvestment = c.String(maxLength: 200),
                        InvestmentAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExecptDate = c.DateTime(nullable: false),
                        ExpireDate = c.DateTime(nullable: false),
                        PresentStatus = c.String(maxLength: 200),
                        OwnBussinessAsset = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GodownStock = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AverageSales = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AverageIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BIID);
            
            CreateTable(
                "dbo.CurrentSavings",
                c => new
                    {
                        CUID = c.Int(nullable: false, identity: true),
                        LoanNo = c.String(nullable: false),
                        TypesofSavings = c.String(),
                        AccountNo = c.String(),
                        AccountopenDate = c.DateTime(nullable: false),
                        InstallmentAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PresentAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.CUID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CurrentSavings");
            DropTable("dbo.BiMudarabas");
        }
    }
}
