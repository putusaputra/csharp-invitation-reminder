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
    public partial class updatePejabat : Form
    {
        c_pejabat cp;
        public updatePejabat()
        {
            InitializeComponent();
        }

        private void updatePejabat_Load(object sender, EventArgs e)
        {
            cp = new c_pejabat();
            cp.tampilPejabat(dataGridView1);
            cp.tampilJabatan(comboBoxJabatan);
        }

        private void bersih()
        {
            textBoxIDpejabat.Clear();
            textBoxNamaPejabat.Clear();
            comboBoxJabatan.ResetText();
            textBoxNotelp.Clear();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxIDpejabat.Text == "")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else if (textBoxNamaPejabat.Text == "")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else if (comboBoxJabatan.Text == "")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else if (textBoxNotelp.Text == "")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else
            {

                cp = new c_pejabat();
                cp.id_pejabat = textBoxIDpejabat.Text;
                cp.nama_pejabat = textBoxNamaPejabat.Text;
                cp.jabatan = comboBoxJabatan.Text;
                cp.no_telp = textBoxNotelp.Text;
                if (cp.updatePejabat())
                {
                    MessageBox.Show("Data berhasil diupdate");
                    cp.tampilPejabat(dataGridView1);
                    bersih();
                }
                else
                {
                    MessageBox.Show("Data gagal diupdate");
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    textBoxIDpejabat.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    textBoxNamaPejabat.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    comboBoxJabatan.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    textBoxNotelp.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
        }
    }
}
