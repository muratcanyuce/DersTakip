using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acme.DersTakip.Business.Concrete;
using Acme.DersTakip.Business.DependencyResolvers.Ninject;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.WinUI
{
    public partial class TeacherForm : Form
    {
        private TeacherManager _teacherManager;
        private InstrumentManager _instrumentManager;
        private List<Teacher> _teachers;
        public TeacherForm()
        {
            InitializeComponent();
            _teacherManager = InstanceFactory.GetInstance<TeacherManager>();
            _instrumentManager = InstanceFactory.GetInstance<InstrumentManager>();
        }
        private void TeacherForm_Load(object sender, EventArgs e)
        {
            cbxTeachersInstrument.DataSource = _instrumentManager.GetAll();
            cbxTeachersInstrument.DisplayMember = "Name";
            LoadTeachers();
        }
        private void LoadTeachers()
        {
            _teachers = _teacherManager.GetTeachersWithInstruments();
            dgwTeachers.DataSource = _teachers;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _teacherManager.Update(new Teacher
                {
                    Id = Convert.ToInt32(dgwTeachers.CurrentRow.Cells["Id"].Value),
                    Name = tbxTeacherName.Text,
                    Surname = tbxTeacherSurname.Text,
                    Phone = tbxTeacherPhone.Text,
                    Email = tbxTeacherEmail.Text

                });
                MessageBox.Show("Öğretmen bilgisi güncellendi!");
                LoadTeachers();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _teacherManager.Delete(new Teacher
            {
                Id = Convert.ToInt32(dgwTeachers.CurrentRow.Cells["Id"].Value)
            });
            MessageBox.Show("Öğretmen bilgisi silindi!");
            LoadTeachers();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _teacherManager.Add(new Teacher
                {
                    Name = tbxTeacherName.Text,
                    Surname = tbxTeacherSurname.Text,
                    Phone = tbxTeacherPhone.Text,
                    Email = tbxTeacherEmail.Text
                });
                MessageBox.Show("Öğretmen bilgisi eklendi!");
                LoadTeachers();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dgwTeachers.CurrentRow.Cells["Id"].Value);
            var teacher = _teachers.FirstOrDefault(p => p.Id == id);
            tbxTeacherName.Text = teacher.Name;
            tbxTeacherSurname.Text = teacher.Surname;
            tbxTeacherPhone.Text = teacher.Phone;
            tbxTeacherEmail.Text = teacher.Email;
            dgwTeachersInstrument.DataSource = teacher.Instruments.ToList();
        }

        private void btnAddTeachersInstrument_Click(object sender, EventArgs e)
        {
            var teacherId = Convert.ToInt32(dgwTeachers.CurrentRow.Cells["Id"].Value);
            var teacher = _teacherManager.Get(x => x.Id == teacherId);
            var selectedInstrument = (Instrument)cbxTeachersInstrument.SelectedItem;
            teacher.Instruments.Add(selectedInstrument);
            _teacherManager.UpdateTeacherInstruments(teacherId, selectedInstrument.Id);
            LoadTeachers();
        }
    }
}
