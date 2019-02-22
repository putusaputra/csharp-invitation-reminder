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
    public partial class Undangan : Form
    {
        Pejabat pj;
        Reminder rm;
        c_undangan cu;
        c_detailundangan cdu;
        tampilUndangan tu;
        tampilPejabat tp;
        public Undangan()
        {
            InitializeComponent();
        }

        private void inputDataPejabatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pj = new Pejabat();
            pj.Show();
        }

        private void inputDataReminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rm = new Reminder();
            rm.Show();
        }

        private void Undangan_Load(object sender, EventArgs e)
        {
            
            cu = new c_undangan();
            textBoxIDundangan.Text = cu.Idundangan();
            for (int i = 0; i <= 24; i++)
            {
                if (i.ToString().Length == 1)
                {
                    comboBoxJam2.Items.Add("0" + i);
                }
                else
                {
                    comboBoxJam2.Items.Add(i);
                }
            }

            for (int i = 0; i <= 59; i++)
            {
                if (i.ToString().Length == 1)
                {
                    comboBoxMenit2.Items.Add("0" + i);
                }
                else
                {
                    comboBoxMenit2.Items.Add(i);
                }
            }

            this.ActiveControl = textBoxIDdisposisi;
        }

        private void bersih()
        {
            cu = new c_undangan();
            textBoxIDundangan.Text = cu.Idundangan();
            textBoxIDdisposisi.Clear();
            richTextBoxDisposisiKalimat.Clear();
            dateTimePickerTanggalUndangan.ResetText();
            comboBoxJam2.ResetText();
            comboBoxMenit2.ResetText();
            textBoxLokasiUndangan.Clear();
            textBoxMateri.Clear();
            textBoxPakaian.Clear();
            textBoxPerlengkapan.Clear();
            textBoxNamaPengirim.Clear();
            textBoxNoSurat.Clear();
            textBoxContactPerson.Clear();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            
            if(textBoxIDundangan.Text=="")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else if(textBoxIDdisposisi.Text=="")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else if (richTextBoxDisposisiKalimat.Text == "")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else if (comboBoxJam2.Text == "")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else if (comboBoxMenit2.Text == "")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else if (textBoxLokasiUndangan.Text == "")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else if (textBoxMateri.Text == "")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else if (textBoxPakaian.Text == "")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else if (textBoxPerlengkapan.Text == "")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else if (textBoxNamaPengirim.Text == "")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else if (textBoxNoSurat.Text == "")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else if (textBoxContactPerson.Text == "")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else
            {

                //t_undangan
                cu = new c_undangan();
                cu.tanggal_terima = string.Format("{0:yyyy/MM/dd}", DateTime.Now.Date);
                cu.jam_terima = string.Format("{0:HH:mm:ss}", DateTime.Now);
                cu.id_undangan = textBoxIDundangan.Text;
                cu.id_disposisi = textBoxIDdisposisi.Text;
                cu.disposisi_kalimat = richTextBoxDisposisiKalimat.Text;

                //t_detail_undangan
                cdu = new c_detailundangan();
                cdu.id_undangan = textBoxIDundangan.Text;
                cdu.tanggal_undangan = string.Format("{0:yyyy/MM/dd}", dateTimePickerTanggalUndangan.Value.Date);
                cdu.jam_undangan = comboBoxJam2.Text + ":" + comboBoxMenit2.Text;
                cdu.lokasi_undangan = textBoxLokasiUndangan.Text;
                cdu.materi = textBoxMateri.Text;
                cdu.pakaian = textBoxPakaian.Text;
                cdu.perlengkapan = textBoxPerlengkapan.Text;
                cdu.nama_pengirim = textBoxNamaPengirim.Text;
                cdu.no_surat = textBoxNoSurat.Text;
                cdu.contact_person = textBoxContactPerson.Text;

                if (cu.insertUndangan() && cdu.insertdetUndangan())
                {
                    MessageBox.Show("Data berhasil disimpan");
                    bersih();
                }
                else
                {
                    MessageBox.Show("Data gagal disimpan");
                    cu.id_undangan = textBoxIDundangan.Text;
                    cu.deleteUndangan();

                    cdu.id_undangan = textBoxIDundangan.Text;
                    cdu.deletedetUndangan();
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            bersih();
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

        private void inputDataPejabatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pj = new Pejabat();
            pj.Show();
        }

        private void inputDataReminderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rm = new Reminder();
            rm.Show();
        }

        

        


        
    }
}
