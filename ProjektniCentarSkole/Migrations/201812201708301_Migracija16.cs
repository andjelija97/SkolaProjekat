namespace ProjektniCentarSkole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracija16 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "AccessFailedCount");
            AddColumn("dbo.AspNetUsers", "AccessFailedCount", c => c.Int(nullable: false));


        }

        public override void Down()
        {
        }
    }
}
