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
        public DbSet <Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<TeacherInstrument> TeacherInstruments { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

    }
}
