namespace ProjektniCentarSkole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class devetaMigracija : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "PhoneNumberConfirmed", c=>c.String(nullable: false));
        }
        
        public override void Down()
        {
        }
    }
}
