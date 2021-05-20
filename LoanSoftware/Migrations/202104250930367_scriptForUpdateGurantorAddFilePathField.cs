namespace LoanSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scriptForUpdateGurantorAddFilePathField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guarantors", "FilePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Guarantors", "FilePath");
        }
    }
}
