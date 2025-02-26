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
using Acme.DersTakip.Business.DependencyResolvers.Ninject;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.WinUI
{
    public partial class StudentForm : Form
    {
        private StudentManager _studentManager;

        public StudentForm()
        {
            InitializeComponent();
            _studentManager = InstanceFactory.GetInstance<StudentManager>();
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwStudent.DataSource = _studentManager.GetAll();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _studentManager.Update(new Student
                {
                    Id = Convert.ToInt32(dgwStudent.CurrentRow.Cells[0].Value),
                    Name = tbxStudentName.Text,
                    Surname = tbxStudentSurname.Text,
                    Phone = tbxStudentPhone.Text,
                    ParentName = tbxParentName.Text,
                    ParentSurname = tbxParentSurname.Text,
                    ParentPhone = tbxParentPhone.Text
                });
                MessageBox.Show("Öğrenci bilgisi güncellendi!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _studentManager.Delete(new Student
            {
                Id = Convert.ToInt32(dgwStudent.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Öğrenci bilgisi silindi!");
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _studentManager.Add(new Student
                {
                    Name = tbxStudentName.Text,
                    Surname = tbxStudentSurname.Text,
                    Phone = tbxStudentPhone.Text,
                    ParentName = tbxParentName.Text,
                    ParentSurname = tbxParentSurname.Text,
                    ParentPhone = tbxParentPhone.Text
                });
                MessageBox.Show("Öğrenci bilgisi eklendi!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
        private void dgwStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwStudent.CurrentRow;

            tbxStudentName.Text = row.Cells[1].Value.ToString();
            tbxStudentSurname.Text = row.Cells[2].Value.ToString();
            tbxStudentPhone.Text = row.Cells[3].Value.ToString();
            tbxParentName.Text = row.Cells[4].Value.ToString();
            tbxParentSurname.Text = row.Cells[5].Value.ToString();
            tbxParentPhone.Text = row.Cells[6].Value.ToString();
        }
    }
}
