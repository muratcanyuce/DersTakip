using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acme.DersTakip.Business.Concrete;
using Acme.DersTakip.Entity.Concrete;

namespace Acme.DersTakip.WinUI
{
    public partial class InstrumentForm : Form
    {
        private InstrumentManager _instrumentManager;
        public InstrumentForm()
        {
            InitializeComponent();
            _instrumentManager = new InstrumentManager();
            LoadProducts();
        }
        private void LoadProducts()
        {
            dgwInstrument.DataSource = _instrumentManager.GetAll();
        }

        private void btnInstrumentAdd_Click(object sender, EventArgs e)
        {
            _instrumentManager.Add(new Instrument
            {
                Name = tbxInstrumentName.Text
            });
            MessageBox.Show("Enstrüman eklendi!");
            LoadProducts();
        }

        private void btnInstrumentUpdate_Click(object sender, EventArgs e)
        {
            _instrumentManager.Update(new Instrument
            {
                Id = Convert.ToInt32(dgwInstrument.CurrentRow.Cells[0].Value),
                Name = tbxInstrumentName.Text
            });
            MessageBox.Show("Enstrüman güncellendi!");
            LoadProducts();
        }
        private void btnInstrumentDelete_Click(object sender, EventArgs e)
        {
            _instrumentManager.Delete(new Instrument
            {
                Id = Convert.ToInt32(dgwInstrument.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Enstrüman silindi!");
            LoadProducts();
        }

        private void dgwInstrumentName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxInstrumentName.Text = dgwInstrument.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
