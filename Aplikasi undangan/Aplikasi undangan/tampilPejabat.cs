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
    public partial class tampilPejabat : Form
    {
        c_pejabat cp;
        c_undangan cu;
        public tampilPejabat()
        {
            InitializeComponent();
        }

        private void tampilPejabat_Load(object sender, EventArgs e)
        {
            cp = new c_pejabat();
            cp.tampilPejabat(dataGridView1);
            for (int i = 1; i <= 4; i++)
            {
                dataGridView1.Columns[i].Width = 200;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == dataGridView1.Columns["ColumnHapus"].Index)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() != "")
                    {
                        if (MessageBox.Show("Apakah anda yakin menghapus data ini ?? semua data undangan yang berkaitan dengan data ini akan dihapus juga", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            cp = new c_pejabat();
                            cu = new c_undangan();
                            cu.id_disposisi = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                            cp.id_pejabat = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                            if (cp.deletePejabat() && cu.deleteUndanganPejabat())
                            {
                                MessageBox.Show("Data berhasil dihapus");
                                cp.tampilPejabat(dataGridView1);
                            }
                            else
                            {
                                MessageBox.Show("Data gagal dihapus");
                            }
                        }
                    }
                }
            }
        }

        private void buttonNIP_Click(object sender, EventArgs e)
        {
            cp = new c_pejabat();
            cp.tampilPejabatNIP(dataGridView1, textBoxCari.Text);
        }

        private void buttonNama_Click(object sender, EventArgs e)
        {
            cp = new c_pejabat();
            cp.tampilPejabatNama(dataGridView1, textBoxCari.Text);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            cp = new c_pejabat();
            cp.tampilPejabat(dataGridView1);
        }

        
    }
}
