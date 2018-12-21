namespace ProjektniCentarSkole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracija14 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "TwoFactorEnabled");
            AddColumn("dbo.AspNetUsers", "TwoFactorEnabled", c=>c.Boolean(nullable:false));
        }
        
        public override void Down()
        {
        }
    }
}
