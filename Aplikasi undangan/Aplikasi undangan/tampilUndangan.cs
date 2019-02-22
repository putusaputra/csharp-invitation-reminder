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
    public partial class tampilUndangan : Form
    {
        c_undangan cu;
        c_detailundangan cdu;
        
        public tampilUndangan()
        {
            InitializeComponent();
        }

        private void tampilUndangan_Load(object sender, EventArgs e)
        {

            cu = new c_undangan();
            cu.tampilUndangan(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == dataGridView1.Columns["ColumnHapus"].Index)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() != "")
                    {
                        cdu = new c_detailundangan();
                        cdu.id_undangan = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                        cu = new c_undangan();
                        cu.id_undangan = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        if (cdu.deletedetUndangan() && cu.deleteUndangan())
                        {
                            MessageBox.Show("Data berhasil dihapus");
                            cu.tampilUndangan(dataGridView1);
                        }
                        else
                        {
                            MessageBox.Show("Data gagal dihapus");
                        }
                    }
                }
            }
        }

        

        private void buttonReset_Click(object sender, EventArgs e)
        {
            cu = new c_undangan();
            cu.tampilUndangan(dataGridView1);
            textBoxNoBerkas.Clear();
            textBoxPengundang.Clear();
            textBoxNoSurat.Clear();
            textBoxMateri.Clear();
            textBoxDisposisi.Clear();
            textBoxDisposisiKalimat.Clear();
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            cu = new c_undangan();
            cu.id_undangan=textBoxNoBerkas.Text;
            cu.nama_pengirim=textBoxPengundang.Text;
            cu.no_surat=textBoxNoSurat.Text;
            cu.materi=textBoxMateri.Text;
            cu.jabatan=textBoxDisposisi.Text;
            cu.disposisi_kalimat=textBoxDisposisiKalimat.Text;
            cu.tampilCari(dataGridView1);
        }

        

        
    }
}
