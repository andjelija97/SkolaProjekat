namespace ProjektniCentarSkole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracija12 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "PhoneNumberConfirmed");
        }
        
        public override void Down()
        {
        }
    }
}
