namespace ProjektniCentarSkole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracija15 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "LockoutEnabled");
            AddColumn("dbo.AspNetUsers", "LockoutEnabled", c => c.Boolean(nullable: false));

        }

        public override void Down()
        {
        }
    }
}
