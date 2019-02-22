using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace Aplikasi_undangan
{
    class c_reminderbidang
    {
        public void tampilUndanganparsatu(System.Windows.Forms.DataGridView ab, string jabatan)
        {

            try
            {
                string comm = "select t_detail_undangan.id_undangan as 'No Berkas', date_format(t_detail_undangan.tanggal_undangan,'%d/%m/%Y') as 'Tanggal Undangan', time_format(t_detail_undangan.jam_undangan,'%H:%i') as 'Jam Undangan', t_detail_undangan.lokasi_undangan as 'Lokasi Undangan', t_pejabat.nama_pejabat as Disposisi, t_pejabat.jabatan as Jabatan, t_detail_undangan.nama_pengirim as 'Nama Pengirim' from t_detail_undangan inner join t_undangan on t_undangan.id_undangan=t_detail_undangan.id_undangan inner join t_pejabat on t_undangan.id_disposisi=t_pejabat.id_pejabat where t_detail_undangan.tanggal_undangan='" + string.Format("{0:yyyy/MM/dd}", DateTime.Now.Date) + "' and t_pejabat.jabatan='" + jabatan + "' order by t_detail_undangan.tanggal_undangan desc";
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

        public void tampilUndanganparload(System.Windows.Forms.DataGridView ab)
        {

            try
            {
                string comm = "select t_detail_undangan.id_undangan as 'No Berkas', date_format(t_detail_undangan.tanggal_undangan,'%d/%m/%Y') as 'Tanggal Undangan', time_format(t_detail_undangan.jam_undangan,'%H:%i') as 'Jam Undangan', t_detail_undangan.lokasi_undangan as 'Lokasi Undangan', t_pejabat.nama_pejabat as Disposisi, t_pejabat.jabatan as Jabatan, t_detail_undangan.nama_pengirim as 'Nama Pengirim' from t_detail_undangan inner join t_undangan on t_undangan.id_undangan=t_detail_undangan.id_undangan inner join t_pejabat on t_undangan.id_disposisi=t_pejabat.id_pejabat where t_detail_undangan.tanggal_undangan='" + string.Format("{0:yyyy/MM/dd}", DateTime.Now.Date) + "' order by t_detail_undangan.tanggal_undangan desc";
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

        public void tampilUndanganpardua(System.Windows.Forms.DataGridView ab, string jabatan)
        {
            try
            {
                string comm = "select t_detail_undangan.id_undangan as 'No Berkas', date_format(t_detail_undangan.tanggal_undangan,'%d/%m/%Y') as 'Tanggal Undangan', time_format(t_detail_undangan.jam_undangan,'%H:%i') as 'Jam Undangan', t_detail_undangan.lokasi_undangan as 'Lokasi Undangan', t_pejabat.nama_pejabat as Disposisi, t_pejabat.jabatan as Jabatan, t_detail_undangan.nama_pengirim as 'Nama Pengirim' from t_detail_undangan inner join t_undangan on t_undangan.id_undangan=t_detail_undangan.id_undangan inner join t_pejabat on t_undangan.id_disposisi=t_pejabat.id_pejabat where t_detail_undangan.tanggal_undangan>='" + string.Format("{0:yyyy/MM/dd}", DateTime.Now.Date) + "' and t_detail_undangan.tanggal_undangan<=DATE_ADD(now(), INTERVAL 2 DAY) and t_pejabat.jabatan='" + jabatan + "' order by t_detail_undangan.tanggal_undangan desc";
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

        public void tampilUndanganpartiga(System.Windows.Forms.DataGridView ab, string jabatan)
        {
            try
            {
                string comm = "select t_detail_undangan.id_undangan as 'No Berkas', date_format(t_detail_undangan.tanggal_undangan,'%d/%m/%Y') as 'Tanggal Undangan', time_format(t_detail_undangan.jam_undangan,'%H:%i') as 'Jam Undangan', t_detail_undangan.lokasi_undangan as 'Lokasi Undangan', t_pejabat.nama_pejabat as Disposisi, t_pejabat.jabatan as Jabatan, t_detail_undangan.nama_pengirim as 'Nama Pengirim' from t_detail_undangan inner join t_undangan on t_undangan.id_undangan=t_detail_undangan.id_undangan inner join t_pejabat on t_undangan.id_disposisi=t_pejabat.id_pejabat where t_detail_undangan.tanggal_undangan>='" + string.Format("{0:yyyy/MM/dd}", DateTime.Now.Date) + "' and t_detail_undangan.tanggal_undangan<=DATE_ADD(now(), INTERVAL 3 DAY) and t_pejabat.jabatan='" + jabatan + "' order by t_detail_undangan.tanggal_undangan desc";
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

        public void tampilUndanganparminggu(System.Windows.Forms.DataGridView ab, string jabatan)
        {
            try
            {
                string comm = "select t_detail_undangan.id_undangan as 'No Berkas', date_format(t_detail_undangan.tanggal_undangan,'%d/%m/%Y') as 'Tanggal Undangan', time_format(t_detail_undangan.jam_undangan,'%H:%i') as 'Jam Undangan', t_detail_undangan.lokasi_undangan as 'Lokasi Undangan', t_pejabat.nama_pejabat as Disposisi, t_pejabat.jabatan as Jabatan, t_detail_undangan.nama_pengirim as 'Nama Pengirim' from t_detail_undangan inner join t_undangan on t_undangan.id_undangan=t_detail_undangan.id_undangan inner join t_pejabat on t_undangan.id_disposisi=t_pejabat.id_pejabat where t_detail_undangan.tanggal_undangan>='" + string.Format("{0:yyyy/MM/dd}", DateTime.Now.Date) + "' and t_detail_undangan.tanggal_undangan<=DATE_ADD(now(), INTERVAL 1 WEEK) and t_pejabat.jabatan='" + jabatan + "' order by t_detail_undangan.tanggal_undangan desc";
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
