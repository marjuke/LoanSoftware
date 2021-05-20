namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scr003 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Guarantors", "GuarantorDateofBirth", c => c.DateTime());
            AlterColumn("dbo.Guarantors", "GuarantorDmcbSavingAmount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Guarantors", "GuarantorDmcbLoanAmount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Guarantors", "GuarantorInstallmentAmount", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Guarantors", "GuarantorInstallmentAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Guarantors", "GuarantorDmcbLoanAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Guarantors", "GuarantorDmcbSavingAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Guarantors", "GuarantorDateofBirth", c => c.DateTime(nullable: false));
        }
    }
}
