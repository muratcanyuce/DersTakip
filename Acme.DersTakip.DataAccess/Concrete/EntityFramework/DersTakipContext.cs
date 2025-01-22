using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Concrete;


namespace Acme.DersTakip.DataAccess.Concrete.EntityFramework
{
    public class DersTakipContext : DbContext
    {
        public DersTakipContext() : base("DersTakip")
        {
                
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Schedules)
                .WithRequired(s => s.Teacher)
                .HasForeignKey(s => s.TeacherId);

            modelBuilder.Entity<Student>()
                .HasMany(t => t.Schedules)
                .WithRequired(s => s.Student)
                .HasForeignKey(s => s.StudentId);

            modelBuilder.Entity<Instrument>()
                .HasMany(t => t.Schedules)
                .WithRequired(s => s.Instrument)
                .HasForeignKey(s => s.InstrumentId);

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Instruments)
                .WithMany(i => i.Teachers)
                .Map(ti =>
                {
                    ti.MapLeftKey("TeacherRefId");
                    ti.MapRightKey("InstrumentRefId");
                    ti.ToTable("TeacherInstrument");
                });

        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

    }
}
