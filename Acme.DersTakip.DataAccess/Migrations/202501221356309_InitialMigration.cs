namespace Acme.DersTakip.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Instruments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeacherId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        InstrumentId = c.Int(nullable: false),
                        ScheduleDateTime = c.DateTime(nullable: false),
                        Fee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .ForeignKey("dbo.Instruments", t => t.InstrumentId, cascadeDelete: true)
                .Index(t => t.TeacherId)
                .Index(t => t.StudentId)
                .Index(t => t.InstrumentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Phone = c.String(),
                        ParentName = c.String(),
                        ParentSurname = c.String(),
                        ParentPhone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeacherInstrument",
                c => new
                    {
                        TeacherRefId = c.Int(nullable: false),
                        InstrumentRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeacherRefId, t.InstrumentRefId })
                .ForeignKey("dbo.Teachers", t => t.TeacherRefId, cascadeDelete: true)
                .ForeignKey("dbo.Instruments", t => t.InstrumentRefId, cascadeDelete: true)
                .Index(t => t.TeacherRefId)
                .Index(t => t.InstrumentRefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "InstrumentId", "dbo.Instruments");
            DropForeignKey("dbo.Schedules", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.TeacherInstrument", "InstrumentRefId", "dbo.Instruments");
            DropForeignKey("dbo.TeacherInstrument", "TeacherRefId", "dbo.Teachers");
            DropForeignKey("dbo.Schedules", "StudentId", "dbo.Students");
            DropIndex("dbo.TeacherInstrument", new[] { "InstrumentRefId" });
            DropIndex("dbo.TeacherInstrument", new[] { "TeacherRefId" });
            DropIndex("dbo.Schedules", new[] { "InstrumentId" });
            DropIndex("dbo.Schedules", new[] { "StudentId" });
            DropIndex("dbo.Schedules", new[] { "TeacherId" });
            DropTable("dbo.TeacherInstrument");
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Schedules");
            DropTable("dbo.Instruments");
        }
    }
}
