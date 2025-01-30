namespace Acme.DersTakip.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScheduleDurationUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schedules", "Duration", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schedules", "Duration");
        }
    }
}
