using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acme.DersTakip.Business.Concrete;
using Acme.DersTakip.Entity.Concrete;
using Acme.DersTakip.WinUI.DTOs;
using DevExpress.Utils.Behaviors.Common;

namespace Acme.DersTakip.WinUI
{
    public partial class ScheduleAppearanceForm : Form
    {
        private ScheduleManager _scheduleManager;
        private TeacherManager _teacherManager;
        private InstrumentManager _instrumentManager;
        public ScheduleAppearanceForm()
        {
            InitializeComponent();
            _scheduleManager = new ScheduleManager();
            _teacherManager = new TeacherManager();
            _instrumentManager = new InstrumentManager();
        }

        private void ScheduleAppearanceForm_Load(object sender, EventArgs e)
        {
            var scheduleDtos = new List<ScheduleDto>();
            var schedules = _scheduleManager.GetSchedulesFull();
            foreach (var schedule in schedules)
            {
                scheduleDtos.Add(new ScheduleDto
                {
                    Id = schedule.Id,
                    TeacherId = schedule.TeacherId,
                    StudentId = schedule.StudentId,
                    InstrumentId = schedule.InstrumentId,
                    TeacherName = string.Join(" ", schedule.Teacher.Name, schedule.Teacher.Surname),
                    StudentName = String.Join(" ", schedule.Student.Name, schedule.Student.Surname),
                    InstrumentName = schedule.Instrument.Name,
                    ScheduleDateTime = schedule.ScheduleDateTime,
                    Fee = schedule.Fee,
                    Description = schedule.Description,
                    Status = schedule.Status,
                    Duration = schedule.Duration
                });
            }
            scheduleDtoBindingSource.DataSource = scheduleDtos;
            teacherBindingSource.DataSource = _teacherManager.GetAll();
            instrumentBindingSource.DataSource = _instrumentManager.GetAll();
            //schedulerDataStorage1.Appointments.DataSource = scheduleDtos;
            //schedulerDataStorage1.Resources.DataSource = _teacherManager.GetAll();


        }
    }
}
