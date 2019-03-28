namespace FestivalAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Festivaliers", "DateNaissance", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Festivaliers", "DateNaissance", c => c.DateTime(nullable: false));
        }
    }
}
