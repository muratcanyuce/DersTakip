using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acme.DersTakip.WinUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
        }

        private void eğitmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();
            teacherForm.Show();
        }

        private void enstrümanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstrumentForm instrumentForm = new InstrumentForm();
            instrumentForm.Show();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleNewForm scheduleNewForm = new ScheduleNewForm();
            scheduleNewForm.Show();
        }

        private void takvimGörünümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleAppearanceForm scheduleAppearanceForm = new ScheduleAppearanceForm();
            scheduleAppearanceForm.Show();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
