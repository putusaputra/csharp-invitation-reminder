using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplikasi_undangan
{
    public partial class reportUndangan : Form
    {
        c_pejabat cp;
        public reportUndangan()
        {
            InitializeComponent();
        }

        private void reportUndangan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'd_undanganDataSet1.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.d_undanganDataSet1.DataTable2, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date,comboBoxJabatan.Text);
            cp = new c_pejabat();
            cp.tampilJabatan(comboBoxJabatan);

           

            this.reportViewer1.RefreshReport();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            
            this.DataTable2TableAdapter.Fill(this.d_undanganDataSet1.DataTable2, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date, comboBoxJabatan.Text);
            



            this.reportViewer1.RefreshReport();
            // TODO: This line of code loads data into the 'd_undanganDataSet.DataTable1' table. You can move, or remove it, as needed.
            
        }
    }
}
