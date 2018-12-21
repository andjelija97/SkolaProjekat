namespace ProjektniCentarSkole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracija13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "PhoneNumberConfirmed", c=>c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
        }
    }
}
