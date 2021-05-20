namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AreadCode : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        AreaID = c.Int(nullable: false, identity: true),
                        AreaName = c.String(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.AreaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Areas");
        }
    }
}
