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
    public partial class updateUndangan : Form
    {
        c_undangan cu;
        c_detailundangan cdu;
        string tanggalterima = "";
        string jamterima = "";
        public updateUndangan()
        {
            InitializeComponent();
        }

        private void updateUndangan_Load(object sender, EventArgs e)
        {
            cu = new c_undangan();
            cu.tampilUndangan(dataGridView1);
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxIDundangan.Text == "")
            { MessageBox.Show("Data tidak boleh kosong"); }
            else if (textBoxIDdisposisi.Text == "")
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
                //undangan
                cu = new c_undangan();

                cu.id_undangan = textBoxIDundangan.Text;
                cu.id_disposisi = textBoxIDdisposisi.Text;
                cu.disposisi_kalimat = richTextBoxDisposisiKalimat.Text;

                //detailundangan
                cdu = new c_detailundangan();
                cdu.id_undangan = textBoxIDundangan.Text;
                cdu.tanggal_undangan = string.Format("{0:yyyy/MM/dd}", dateTimePickerTanggalUndangan.Value);
                cdu.jam_undangan = comboBoxJam2.Text + ":" + comboBoxMenit2.Text;
                cdu.lokasi_undangan = textBoxLokasiUndangan.Text;
                cdu.materi = textBoxMateri.Text;
                cdu.pakaian = textBoxPakaian.Text;
                cdu.perlengkapan = textBoxPerlengkapan.Text;
                cdu.nama_pengirim = textBoxNamaPengirim.Text;
                cdu.no_surat = textBoxNoSurat.Text;
                cdu.contact_person = textBoxContactPerson.Text;

                if (cdu.updatedetUndangan() && cu.updateUndangan())
                {
                    MessageBox.Show("Data berhasil diupdate");
                    cu.tampilUndangan(dataGridView1);
                    bersih();
                }
                else
                {
                    MessageBox.Show("Data gagal diupdate");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    tanggalterima = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    jamterima = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string tanggal = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString().Substring(0, 2);
                    string bulan = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString().Substring(3, 2);
                    string tahun = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString().Substring(6, 4);
                    textBoxIDundangan.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    textBoxIDdisposisi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    richTextBoxDisposisiKalimat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    dateTimePickerTanggalUndangan.Value = DateTime.Parse(bulan + "/" + tanggal + "/" + tahun);
                    comboBoxJam2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString().Substring(0, 2);
                    comboBoxMenit2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString().Substring(3, 2);
                    textBoxLokasiUndangan.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    textBoxMateri.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    textBoxPakaian.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                    textBoxPerlengkapan.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                    textBoxNamaPengirim.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                    textBoxNoSurat.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                    textBoxContactPerson.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();

                }
            }
        }

        
    }
}
