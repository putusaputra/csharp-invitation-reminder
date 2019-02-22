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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'd_undanganDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.d_undanganDataSet1.DataTable1);
            // TODO: This line of code loads data into the 'd_undanganDataSet.t_pejabat' table. You can move, or remove it, as needed.
            
            this.reportViewer1.RefreshReport();
        }
    }
}
