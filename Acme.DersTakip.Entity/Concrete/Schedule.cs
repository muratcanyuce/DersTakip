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
        public int ScheduleId { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
        public int InstrumentId { get; set; }
        public DateTime ScheduleDateTime { get; set; }
        public decimal Fee { get; set; }
        public string ScheduleDescription { get; set; }
        public bool ScheduleStatus { get; set; }

    }
}
