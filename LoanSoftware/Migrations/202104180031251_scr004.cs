namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scr004 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BiMudarabas", "InvestmentAmount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.BiMudarabas", "ExecptDate", c => c.DateTime());
            AlterColumn("dbo.BiMudarabas", "ExpireDate", c => c.DateTime());
            AlterColumn("dbo.BiMudarabas", "OwnBussinessAsset", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.BiMudarabas", "GodownStock", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.BiMudarabas", "AverageSales", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.BiMudarabas", "AverageIncome", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.CurrentSavings", "AccountopenDate", c => c.DateTime());
            AlterColumn("dbo.CurrentSavings", "InstallmentAmount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.CurrentSavings", "PresentAmount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.OtherBanks", "LoanAmount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.OtherBanks", "ExceptLoanDate", c => c.DateTime());
            AlterColumn("dbo.OtherBanks", "ExpireLoanDate", c => c.DateTime());
            AlterColumn("dbo.OtherBanks", "PresentLoanAmount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.RetentionProperties", "MinimumPrice", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RetentionProperties", "MinimumPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.OtherBanks", "PresentLoanAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.OtherBanks", "ExpireLoanDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.OtherBanks", "ExceptLoanDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.OtherBanks", "LoanAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.CurrentSavings", "PresentAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.CurrentSavings", "InstallmentAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.CurrentSavings", "AccountopenDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BiMudarabas", "AverageIncome", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.BiMudarabas", "AverageSales", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.BiMudarabas", "GodownStock", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.BiMudarabas", "OwnBussinessAsset", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.BiMudarabas", "ExpireDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BiMudarabas", "ExecptDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BiMudarabas", "InvestmentAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
