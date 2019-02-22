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
    public partial class reportList : Form
    {
        public reportList()
        {
            InitializeComponent();
        }

        private void reportList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'd_undanganDataSet1.DataTable3' table. You can move, or remove it, as needed.
            this.DataTable3TableAdapter.Fill(this.d_undanganDataSet1.DataTable3);

            this.reportViewer1.RefreshReport();
        }
    }
}
