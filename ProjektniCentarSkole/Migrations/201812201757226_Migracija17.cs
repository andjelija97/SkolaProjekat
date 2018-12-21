namespace ProjektniCentarSkole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracija17 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Password", c=>c.String(nullable: false));
        }
        
        public override void Down()
        {
        }
    }
}
