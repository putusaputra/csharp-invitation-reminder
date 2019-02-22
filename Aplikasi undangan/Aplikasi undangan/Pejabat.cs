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
    public partial class Pejabat : Form
    {
        Undangan ud;
        Reminder rm;
        c_pejabat cp;
        tampilUndangan tu;
        tampilPejabat tp;
        public Pejabat()
        {
            InitializeComponent();
        }

        private void inputDataUndanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ud = new Undangan();
            ud.Show();
        }

        private void inputDataReminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rm = new Reminder();
            rm.Show();
        }

        private void Pejabat_Load(object sender, EventArgs e)
        {
            cp = new c_pejabat();
            cp.tampilJabatan(comboBoxJabatan);
        }

        private void bersih()
        {
            textBoxIDpejabat.Clear();
            textBoxNamaPejabat.Clear();
            comboBoxJabatan.ResetText();
            textBoxNotelp.Clear();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
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
                if (cp.insertPejabat())
                {
                    MessageBox.Show("Data berhasil disimpan");
                    bersih();
                }
                else
                {
                    MessageBox.Show("Data gagal disimpan");
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void inputDataUndanganToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ud = new Undangan();
            ud.Show();
        }

        private void inputDataReminderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rm = new Reminder();
            rm.Show();
        }

        private void tampilanUndanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tu = new tampilUndangan();
            tu.Show();
        }

        private void tampilanPejabatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tp = new tampilPejabat();
            tp.Show();
        }

       
    }
}
