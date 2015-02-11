namespace WaitForIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHashField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Hash", x => x.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "Hash");
        }
    }
}
