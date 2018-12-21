namespace ProjektniCentarSkole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracija11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "PhoneNumberConfirmed", c=>c.Boolean());
        }
        
        public override void Down()
        {
        }
    }
}
