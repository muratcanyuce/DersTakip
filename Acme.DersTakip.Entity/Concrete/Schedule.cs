using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.DersTakip.Entity.Abstract;

namespace Acme.DersTakip.Entity.Concrete
{
    public class Schedule : IEntity
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int InstrumentId { get; set; }
        public Instrument Instrument { get; set; }
        public DateTime ScheduleDateTime { get; set; }
        public decimal Fee { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

    }
}
