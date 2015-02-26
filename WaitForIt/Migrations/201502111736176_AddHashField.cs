namespace WaitForIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHashField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Hash", x => x.String());
            
            // How to give a field the NOT NULL constraint and provide default values
            //AddColumn("dbo.Events", "Hash", x => x.String(nullable: false, defaultValue: "xxxxxxxxx"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "Hash");
        }
    }
}
