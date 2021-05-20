namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addguarantor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guarantors",
                c => new
                    {
                        GID = c.Int(nullable: false, identity: true),
                        LoanNo = c.String(),
                        GuarantorName = c.String(),
                        GuarantorDateofBirth = c.DateTime(nullable: false),
                        GuarantorFather = c.String(),
                        GuarantorMother = c.String(),
                        PermanentVillage = c.String(),
                        GuarantorPO = c.String(),
                        GuarantorPS = c.String(),
                        GuarantorPermanentDistrict = c.String(),
                        GuarantorPresentAddress = c.String(),
                        GuarantorBusinessAddress = c.String(),
                        GuarantorNID = c.String(),
                        GuarantorPhone = c.String(),
                        GuarantorRelation = c.String(),
                        GuarantorOccupation = c.String(),
                        GuarantorDmcbSavingName = c.String(),
                        GuarantorDmcbSavingAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GuarantorDmcbLoanName = c.String(),
                        GuarantorDmcbLoanAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GuarantorInstallmentAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GuarantorSignature = c.String(),
                    })
                .PrimaryKey(t => t.GID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Guarantors");
        }
    }
}
