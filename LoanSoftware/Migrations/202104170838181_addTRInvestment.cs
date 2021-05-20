namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTRInvestment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TRInvestments",
                c => new
                    {
                        TID = c.Int(nullable: false, identity: true),
                        LoanNo = c.String(),
                        TRDate = c.DateTime(nullable: false),
                        SlNo = c.String(),
                        ProductDescription = c.String(),
                        QTY = c.String(),
                        Buyamount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TRSalesAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MinimumProfit = c.String(),
                    })
                .PrimaryKey(t => t.TID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TRInvestments");
        }
    }
}
