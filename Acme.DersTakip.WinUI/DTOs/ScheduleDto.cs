using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Acme.DersTakip.Entity.Concrete;
using DevExpress.XtraScheduler.Outlook.Native;

namespace Acme.DersTakip.WinUI.DTOs
{
    public class ScheduleDto
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int InstrumentId { get; set; }
        public string InstrumentName { get; set; }
        public DateTime ScheduleDateTime { get; set; }
        public decimal Fee { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public int Duration { get; set; }
        public DateTime EndDate
        {
            get
            {
                return ScheduleDateTime.AddMinutes(Duration);
            }
        }
    }
}
