namespace ProjektniCentarSkole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracija18 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Sifra");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Sifra", c => c.String());
        }
    }
}
