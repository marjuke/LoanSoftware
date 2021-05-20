namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scrpt005 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TRInvestments", "TRDate", c => c.DateTime());
            AlterColumn("dbo.TRInvestments", "Buyamount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.TRInvestments", "TRSalesAmount", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TRInvestments", "TRSalesAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TRInvestments", "Buyamount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TRInvestments", "TRDate", c => c.DateTime(nullable: false));
        }
    }
}
