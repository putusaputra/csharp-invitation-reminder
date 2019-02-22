using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace Aplikasi_undangan
{
    class c_detailundangan
    {
        public string id_undangan
        {
            get;
            set;
        }

        public string tanggal_undangan
        {
            get;
            set;
        }

        public string jam_undangan
        {
            get;
            set;
        }

        public string lokasi_undangan
        {
            get;
            set;
        }

        public string materi
        {
            get;
            set;
        }

        public string pakaian
        {
            get;
            set;
        }

        public string perlengkapan
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

        public string contact_person
        {
            get;
            set;
        }

        


        public Boolean insertdetUndangan()
        {
            try
            {
                string comm = "insert into t_detail_undangan values('" + this.id_undangan + "','" + this.tanggal_undangan + "','" + this.jam_undangan + "','" + this.lokasi_undangan + "','" + this.materi + "','"+this.pakaian+"','"+this.perlengkapan+"','"+this.nama_pengirim+"','"+this.no_surat+"','"+this.contact_person+"')";
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

        public Boolean updatedetUndangan()
        {
            try
            {
                string comm = "update t_detail_undangan set tanggal_undangan='" + this.tanggal_undangan + "', jam_undangan='" + this.jam_undangan + "', lokasi_undangan='" + this.lokasi_undangan + "', materi='" + this.materi + "', pakaian='"+this.pakaian+"', perlengkapan='"+this.perlengkapan+"', nama_pengirim='"+this.nama_pengirim+"', no_surat='"+this.no_surat+"', contact_person='"+this.contact_person+"' where id_undangan='" + this.id_undangan + "'";
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

        public Boolean deletedetUndangan()
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

        public void tampildetUndangan(System.Windows.Forms.DataGridView ab)
        {
            try
            {
                string comm = "select id_undangan as 'No Berkas', nama_pengirim as 'Nama Pengirim', date_format(tanggal_masuk,'%d/%m/%Y') as 'Tanggal Masuk',no_surat as 'No Surat', perihal as Perihal, tempat as Tempat, time_format(waktu,'%H:%i') as Waktu, pakaian as Pakaian, disposisi_tujuan as 'Disposisi Tujuan', disposisi_kalimat as 'Disposisi Kalimat' from t_undangan order by tanggal_masuk desc";
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
