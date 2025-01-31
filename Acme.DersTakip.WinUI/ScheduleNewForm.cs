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
        private ScheduleManager _scheduleManager;
        private List<Schedule> _schedules;
        private List<Teacher> _teachers;
        private List<Student> _students;
        //TODO: Schedule validasyonları yapılacak.
      

        public ScheduleNewForm()
        {
            InitializeComponent();
            _teacherManager = new TeacherManager();
            _studentManager = new StudentManager();
            _scheduleManager = new ScheduleManager();
        }

        private void ScheduleNewForm_Load(object sender, EventArgs e)
        {
            _teachers = _teacherManager.GetTeachersWithInstruments();
            cbxTeacherSchedule.DataSource = _teachers;
            cbxTeacherSchedule.DisplayMember = "FullName";
            _students = _studentManager.GetAll();
            cbxStudentSchedule.DataSource = _students;
            cbxStudentSchedule.DisplayMember = "FullName";
            LoadSchedules();
            dtpDateTime.Format = DateTimePickerFormat.Custom;
            dtpDateTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";
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
            dgwScheduleNew.DataSource = schedules;
            dgwScheduleNew.Columns["Id"].Visible = false;
            dgwScheduleNew.Columns["TeacherId"].Visible = false;
            dgwScheduleNew.Columns["StudentId"].Visible = false;
            dgwScheduleNew.Columns["InstrumentId"].Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtpDateTime.Value > DateTime.Now && chkStatusSchedule.Checked)
            {
                MessageBox.Show("Gelecek Tarihli Takvim Güncellenemez !");
                return;
            }

            var schedule = new Schedule
            {
                Id = Convert.ToInt32(dgwScheduleNew.CurrentRow.Cells["Id"].Value),
                TeacherId = ((Teacher)cbxTeacherSchedule.SelectedValue).Id,
                StudentId = ((Student)cbxStudentSchedule.SelectedValue).Id,
                InstrumentId = ((Instrument)cbxInstrumentSchedule.SelectedValue).Id,
                ScheduleDateTime = dtpDateTime.Value,
                Fee = Convert.ToDecimal(tbxFee.Text),
                Description = tbxDescription.Text,
                Status = chkStatusSchedule.Checked,
                Duration = Convert.ToInt32(tbxDuration.Text)
            };
            _scheduleManager.Update(schedule);
            MessageBox.Show("Takvim Güncellendi !");
            LoadSchedules();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int teacherId = ((Teacher)cbxTeacherSchedule.SelectedValue).Id;
            int studentId = ((Student)cbxStudentSchedule.SelectedValue).Id;
            int instrumentId = ((Instrument)cbxInstrumentSchedule.SelectedValue).Id;

            if (tbxFee.Text == "" || tbxDuration.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz !");
                return;
            }
            bool isNumber = int.TryParse(tbxFee.Text, out int fee);
            
            if (!isNumber)
            {
                MessageBox.Show("Ücret Alanına Sadece Sayı Girilebilir !");
                return;
            }

                _scheduleManager.Add(new Schedule
            {
                TeacherId = teacherId,
                StudentId = studentId,
                InstrumentId = instrumentId,
                ScheduleDateTime = dtpDateTime.Value,
                Description = tbxDescription.Text,
                Fee = Convert.ToDecimal(tbxFee.Text),
                Status = chkStatusSchedule.Checked,
                Duration = Convert.ToInt32(tbxDuration.Text)
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
            Teacher teacher = _teachers.FirstOrDefault(x => x.Id == Convert.ToInt32(dgwScheduleNew.CurrentRow.Cells["TeacherId"].Value));
            cbxTeacherSchedule.SelectedIndex = cbxTeacherSchedule.FindStringExact(teacher.FullName);
            Student student = _students.FirstOrDefault(x => x.Id == Convert.ToInt32(dgwScheduleNew.CurrentRow.Cells["StudentId"].Value));
            cbxStudentSchedule.SelectedIndex = cbxStudentSchedule.FindStringExact(student.FullName);
            Instrument instrument = teacher.Instruments.FirstOrDefault(x => x.Id == Convert.ToInt32(dgwScheduleNew.CurrentRow.Cells["InstrumentId"].Value));
            cbxInstrumentSchedule.SelectedIndex = cbxInstrumentSchedule.FindStringExact(instrument.Name);
            dtpDateTime.Value = Convert.ToDateTime(dgwScheduleNew.CurrentRow.Cells["ScheduleDateTime"].Value);
            tbxFee.Text = dgwScheduleNew.CurrentRow.Cells["Fee"].Value.ToString();
            tbxDescription.Text = dgwScheduleNew.CurrentRow.Cells["Description"].Value.ToString();
            chkStatusSchedule.Checked = Convert.ToBoolean(dgwScheduleNew.CurrentRow.Cells["Status"].Value);
            tbxDuration.Text = dgwScheduleNew.CurrentRow.Cells["Duration"].Value.ToString();
        }

        private void cbxTeacherSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            Teacher teacher = ((ComboBox)sender).SelectedItem as Teacher;
            cbxInstrumentSchedule.DataSource = teacher.Instruments.ToList();
            cbxInstrumentSchedule.DisplayMember = "Name";
        }
    }
}

