using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace Aplikasi_undangan
{
    class c_undangan
    {
        

        public string tanggal_terima
        {
            get;
            set;
        }

        public string jam_terima
        {
            get;
            set;
        }

        public string id_undangan
        {
            get;
            set;
        }

        public string id_disposisi
        {
            get;
            set;
        }

        public string disposisi_kalimat
        {
            get;
            set;
        }

        public string nama_pengirim
        {
            get;
            set;
        }

        public string no_surat
        {
            get;
            set;
        }

        public string materi
        {
            get;
            set;
        }

        public string jabatan
        {
            get;
            set;
        }

        public String Idundangan()
        {
            string jml = "";
            string hasil = "";
            string angka = "0000";
            int konversi = 0;
            OdbcConnection conn = new OdbcConnection(Program.konek);
            OdbcCommand comm = new OdbcCommand("select max(id_undangan) from t_undangan where tanggal_terima='" + string.Format("{0:yyyy/MM/dd}", DateTime.Now.Date) + "'", conn);
            conn.Open();
            DataSet ds = new DataSet();
            OdbcDataAdapter da = new OdbcDataAdapter(comm);
            da.Fill(ds);
            conn.Close();
            if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "")
            {
                jml = "1";
                hasil = string.Format("{0:MMddyyyy0001}", DateTime.Now.Date);
            }
            else
            {

                konversi = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString().Substring(8, 4));
                konversi += 1;
                if (konversi.ToString().Length > 0)
                {
                    jml = string.Format("{0:MMddyyyy}", DateTime.Now.Date) + angka.Substring(0, angka.Length - konversi.ToString().Length) + konversi.ToString();
                }
                hasil = jml;
            }
            return hasil;
        }


        public Boolean insertUndangan()
        {
            try
            {
                string comm = "insert into t_undangan values('" + this.tanggal_terima + "','" + this.jam_terima + "','" + this.id_undangan + "','" + this.id_disposisi + "','" + this.disposisi_kalimat + "')";
                OdbcConnection conn = new OdbcConnection(Program.konek);
                OdbcCommand comd = new OdbcCommand(comm, conn);
                conn.Open();
                DataSet ds = new DataSet();
                OdbcDataAdapter da = new OdbcDataAdapter(comd);
                da.Fill(ds);
                conn.Close();

                return true;
            }
            catch (OdbcException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean updateUndangan()
        {
            try
            {
                string comm = "update t_undangan set id_disposisi='" + this.id_disposisi + "', disposisi_kalimat='" + this.disposisi_kalimat + "' where id_undangan='" + this.id_undangan + "'";
                OdbcConnection conn = new OdbcConnection(Program.konek);
                OdbcCommand comd = new OdbcCommand(comm, conn);
                conn.Open();
                DataSet ds = new DataSet();
                OdbcDataAdapter da = new OdbcDataAdapter(comd);
                da.Fill(ds);
                conn.Close();

                return true;
            }
            catch (OdbcException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean deleteUndangan()
        {
            try
            {
                string comm = "delete from t_undangan where id_undangan='" + this.id_undangan + "'";
                OdbcConnection conn = new OdbcConnection(Program.konek);
                OdbcCommand comd = new OdbcCommand(comm, conn);
                conn.Open();
                DataSet ds = new DataSet();
                OdbcDataAdapter da = new OdbcDataAdapter(comd);
                da.Fill(ds);
                conn.Close();

                return true;
            }
            catch (OdbcException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean deleteUndanganPejabat()
        {
            try
            {
                string comm = "delete from t_undangan where id_disposisi='" + this.id_disposisi + "'";
                OdbcConnection conn = new OdbcConnection(Program.konek);
                OdbcCommand comd = new OdbcCommand(comm, conn);
                conn.Open();
                DataSet ds = new DataSet();
                OdbcDataAdapter da = new OdbcDataAdapter(comd);
                da.Fill(ds);
                conn.Close();

                return true;
            }
            catch (OdbcException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void tampilUndangan(System.Windows.Forms.DataGridView ab)
        {
            try
            {
                string comm = "select u.id_undangan as 'No Berkas', date_format(u.tanggal_terima,'%d/%m/%Y') as 'Tanggal Terima', time_format(u.jam_terima,'%H:%i') as 'Jam Terima', p.jabatan as 'Disposisi', u.disposisi_kalimat as 'Disposisi Kalimat', date_format(d.tanggal_undangan,'%d/%m/%Y') as 'Tanggal Undangan', time_format(d.jam_undangan,'%H:%i') as 'Jam Undangan', d.lokasi_undangan as 'Lokasi Undangan', d.materi as Materi, d.pakaian as Pakaian, d.perlengkapan as Perlengkapan, d.nama_pengirim as 'Nama Pengirim', d.no_surat as 'No Surat', d.contact_person as 'Contact Person' from t_undangan u inner join t_detail_undangan d on u.id_undangan=d.id_undangan inner join t_pejabat p on u.id_disposisi=p.id_pejabat order by d.tanggal_undangan and d.jam_undangan desc";
                OdbcConnection conn = new OdbcConnection(Program.konek);
                OdbcCommand comd = new OdbcCommand(comm, conn);
                conn.Open();
                DataSet ds = new DataSet();
                OdbcDataAdapter da = new OdbcDataAdapter(comd);
                da.Fill(ds, "isi");
                conn.Close();
                ab.DataSource = ds;
                ab.DataMember = "isi";
            }
            catch (OdbcException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }

        public void tampilCari(System.Windows.Forms.DataGridView ab)
        {
            try
            {
                string comm = "select u.id_undangan as 'No Berkas', date_format(u.tanggal_terima,'%d/%m/%Y') as 'Tanggal Terima', time_format(u.jam_terima,'%H:%i') as 'Jam Terima', p.jabatan as 'Disposisi', u.disposisi_kalimat as 'Disposisi Kalimat', date_format(d.tanggal_undangan,'%d/%m/%Y') as 'Tanggal Undangan', time_format(d.jam_undangan,'%H:%i') as 'Jam Undangan', d.lokasi_undangan as 'Lokasi Undangan', d.materi as Materi, d.pakaian as Pakaian, d.perlengkapan as Perlengkapan, d.nama_pengirim as 'Nama Pengirim', d.no_surat as 'No Surat', d.contact_person as 'Contact Person' from t_undangan u inner join t_detail_undangan d on u.id_undangan=d.id_undangan inner join t_pejabat p on u.id_disposisi=p.id_pejabat where u.id_undangan LIKE '%" + this.id_undangan + "%' and d.nama_pengirim LIKE '%" + this.nama_pengirim + "%' and d.no_surat LIKE '%" + this.no_surat + "%' and d.materi LIKE '%" + this.materi + "%' and p.jabatan LIKE '%" + this.jabatan + "%' and u.disposisi_kalimat LIKE '%" + this.disposisi_kalimat + "%' order by d.tanggal_undangan and d.jam_undangan desc";
                OdbcConnection conn = new OdbcConnection(Program.konek);
                OdbcCommand comd = new OdbcCommand(comm, conn);
                conn.Open();
                DataSet ds = new DataSet();
                OdbcDataAdapter da = new OdbcDataAdapter(comd);
                da.Fill(ds, "isi");
                conn.Close();
                ab.DataSource = ds;
                ab.DataMember = "isi";
            }
            catch (OdbcException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }

        public void tampilMateri(System.Windows.Forms.DataGridView ab, string materi)
        {
            try
            {
                string comm = "select u.id_undangan as 'No Berkas', date_format(u.tanggal_terima,'%d/%m/%Y') as 'Tanggal Terima', time_format(u.jam_terima,'%H:%i') as 'Jam Terima', p.jabatan as 'Disposisi', u.disposisi_kalimat as 'Disposisi Kalimat', date_format(d.tanggal_undangan,'%d/%m/%Y') as 'Tanggal Undangan', time_format(d.jam_undangan,'%H:%i') as 'Jam Undangan', d.lokasi_undangan as 'Lokasi Undangan', d.materi as Materi, d.pakaian as Pakaian, d.perlengkapan as Perlengkapan, d.nama_pengirim as 'Nama Pengirim', d.no_surat as 'No Surat', d.contact_person as 'Contact Person' from t_undangan u inner join t_detail_undangan d on u.id_undangan=d.id_undangan inner join t_pejabat p on u.id_disposisi=p.id_pejabat where d.materi LIKE '%" + materi + "%' order by d.tanggal_undangan and d.jam_undangan desc";
                OdbcConnection conn = new OdbcConnection(Program.konek);
                OdbcCommand comd = new OdbcCommand(comm, conn);
                conn.Open();
                DataSet ds = new DataSet();
                OdbcDataAdapter da = new OdbcDataAdapter(comd);
                da.Fill(ds, "isi");
                conn.Close();
                ab.DataSource = ds;
                ab.DataMember = "isi";
            }
            catch (OdbcException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }
    }
}
