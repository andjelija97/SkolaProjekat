namespace ProjektniCentarSkole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class drugaMigracija : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "PravaPristupa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PravaPristupa");
            DropColumn("dbo.AspNetUsers", "LastName");
        }
    }
}
