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

namespace Acme.DersTakip.WinUI
{
    public partial class ScheduleNewForm : Form
    {
        private TeacherManager _teacherManager;
        private StudentManager _studentManager;
        private InstrumentManager _instrumentManager;
        private ScheduleManager _scheduleManager;
        private List<Schedule> _schedules;
        private List<Teacher> _teachers;
        private List<Student> _students;
        private List<Instrument> _instruments;

        public ScheduleNewForm()
        {
            InitializeComponent();
            _teacherManager = new TeacherManager();
            _instrumentManager = new InstrumentManager();
            _studentManager = new StudentManager();
            _scheduleManager = new ScheduleManager();
        }

        private void ScheduleNewForm_Load(object sender, EventArgs e)
        {
            _teachers = _teacherManager.GetTeachersWithInstruments();
            cbxTeacherSchedule.DataSource = _teachers;
            cbxTeacherSchedule.DisplayMember = "Name";
            _students = _studentManager.GetAll();
            cbxStudentSchedule.DataSource = _students;
            cbxStudentSchedule.DisplayMember = "Name";
            LoadSchedules();
            dtpDateTime.Format = DateTimePickerFormat.Custom;
            dtpDateTime.CustomFormat = "dd.MM.yyyy hh:mm:ss";
        }
        private void LoadSchedules()
        {
            var schedules = new List<ScheduleDto>();
            _schedules = _scheduleManager.GetSchedulesFull();
            foreach (var schedule in _schedules) 
            {
                schedules.Add(new ScheduleDto
                {
                    Id = schedule.Id,
                    TeacherId = schedule.TeacherId,
                    StudentId = schedule.StudentId,
                    InstrumentId = schedule.InstrumentId,
                    TeacherName = schedule.Teacher.Name,
                    StudentName = schedule.Student.Name,
                    InstrumentName = schedule.Instrument.Name,
                    ScheduleDateTime = schedule.ScheduleDateTime,
                    Fee = schedule.Fee,
                    Description = schedule.Description,
                    Status = schedule.Status
                });
            }
            dgwScheduleNew.DataSource = schedules;
            dgwScheduleNew.Columns["Id"].Visible = false;
            dgwScheduleNew.Columns["TeacherId"].Visible = false;
            dgwScheduleNew.Columns["StudentId"].Visible = false;
            dgwScheduleNew.Columns["InstrumentId"].Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _scheduleManager.Update(new Schedule
            {
                Id = Convert.ToInt32(dgwScheduleNew.CurrentRow.Cells["Id"].Value),
                TeacherId = ((Teacher)cbxTeacherSchedule.SelectedValue).Id,
                StudentId = ((Student)cbxStudentSchedule.SelectedValue).Id,
                InstrumentId = ((Instrument)cbxInstrumentSchedule.SelectedValue).Id,
                ScheduleDateTime = dtpDateTime.Value,
                Fee = Convert.ToDecimal(tbxFee.Text),
                Description = tbxDescription.Text,
                Status = chkStatusSchedule.Checked,
            });
            MessageBox.Show("Takvim Güncellendi !");
            LoadSchedules();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int teacherId = ((Teacher)cbxTeacherSchedule.SelectedValue).Id;
            int studentId = ((Student)cbxStudentSchedule.SelectedValue).Id;
            int instrumentId = ((Instrument)cbxInstrumentSchedule.SelectedValue).Id;

            _scheduleManager.Add(new Schedule
            {
                TeacherId = teacherId,
                StudentId = studentId,
                InstrumentId = instrumentId,
                ScheduleDateTime = dtpDateTime.Value,
                Description = tbxDescription.Text,
                Fee = Convert.ToDecimal(tbxFee.Text)
            });
            MessageBox.Show("Takvim Eklendi !");
            LoadSchedules();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _scheduleManager.Delete(new Schedule
            {
                Id = Convert.ToInt32(dgwScheduleNew.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Takvim Silindi !");
            LoadSchedules();
        }

        private void dgwScheduleNew_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwScheduleNew.CurrentRow;
            Teacher teacher = _teachers.FirstOrDefault(x => x.Id == Convert.ToInt32(dgwScheduleNew.CurrentRow.Cells["TeacherId"].Value));
            cbxTeacherSchedule.SelectedIndex = cbxTeacherSchedule.FindStringExact(teacher.Name);
            Student student = _students.FirstOrDefault(x => x.Id == Convert.ToInt32(dgwScheduleNew.CurrentRow.Cells["StudentId"].Value));
            cbxStudentSchedule.SelectedIndex = cbxStudentSchedule.FindStringExact(student.Name);
            Instrument instrument = teacher.Instruments.FirstOrDefault(x => x.Id == Convert.ToInt32(dgwScheduleNew.CurrentRow.Cells["InstrumentId"].Value));
            cbxInstrumentSchedule.SelectedIndex = cbxInstrumentSchedule.FindStringExact(instrument.Name);
            dtpDateTime.Value = Convert.ToDateTime(dgwScheduleNew.CurrentRow.Cells["ScheduleDateTime"].Value);
            tbxFee.Text = dgwScheduleNew.CurrentRow.Cells["Fee"].Value.ToString();
            tbxDescription.Text = dgwScheduleNew.CurrentRow.Cells["Description"].Value.ToString();
            chkStatusSchedule.Checked = Convert.ToBoolean(dgwScheduleNew.CurrentRow.Cells["Status"].Value);
        }

        private void cbxTeacherSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            Teacher teacher = ((ComboBox)sender).SelectedItem as Teacher;
            cbxInstrumentSchedule.DataSource = teacher.Instruments.ToList();
            cbxInstrumentSchedule.DisplayMember = "Name";
        }
    }
}

