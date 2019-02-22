using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;



namespace Aplikasi_undangan
{
    class c_pejabat
    {
        public string id_pejabat
        {
            get;
            set;
        }

        public string nama_pejabat
        {
            get;
            set;
        }

        public string jabatan
        {
            get;
            set;
        }

        public string no_telp
        {
            get;
            set;
        }


        public String Idpejabat()
        {
            string jml = "";
            string hasil = "";
            string angka = "0000";
            int konversi = 0;
            OdbcConnection conn = new OdbcConnection(Program.konek);
            OdbcCommand comm = new OdbcCommand("select max(id_pejabat) from t_pejabat where tanggal_terima='" + string.Format("{0:yyyy/MM/dd}", DateTime.Now.Date) + "'", conn);
            conn.Open();
            DataSet ds = new DataSet();
            OdbcDataAdapter da = new OdbcDataAdapter(comm);
            da.Fill(ds);
            conn.Close();
            if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "")
            {
                jml = "1";
                hasil = string.Format("{0:PMMddyyyy0001}", DateTime.Now.Date);
            }
            else
            {

                konversi = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString().Substring(9, 4));
                konversi += 1;
                if (konversi.ToString().Length > 0)
                {
                    jml = string.Format("{0:PMMddyyyy}", DateTime.Now.Date) + angka.Substring(0, angka.Length - konversi.ToString().Length) + konversi.ToString();
                }
                hasil = jml;
            }
            return hasil;
        }


        public Boolean insertPejabat()
        {
            try
            {
                string comm = "insert into t_pejabat values('" + this.id_pejabat + "','" + this.nama_pejabat + "','" + this.jabatan + "','" + this.no_telp + "')";
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

        public Boolean updatePejabat()
        {
            try
            {
                string comm = "update t_pejabat set nama_pejabat='" + this.nama_pejabat + "', jabatan='" + this.jabatan + "', no_telp='" + this.no_telp + "'where id_pejabat='" + this.id_pejabat + "'";
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

        public Boolean deletePejabat()
        {
            try
            {
                string comm = "delete from t_pejabat where id_pejabat='" + this.id_pejabat + "'";
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

        public void tampilJabatan(System.Windows.Forms.ComboBox ab)
        {
           
            try
            {
                string comm = "select distinct(jabatan) from t_pejabat";
                OdbcConnection conn = new OdbcConnection(Program.konek);
                OdbcCommand comd = new OdbcCommand(comm, conn);
                conn.Open();
                DataSet ds = new DataSet();
                OdbcDataAdapter da = new OdbcDataAdapter(comd);
                da.Fill(ds, "isi");
                conn.Close();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ab.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                }

                ab.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (OdbcException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
        }

        

        

        public void tampilPejabat(System.Windows.Forms.DataGridView ab)
        {
            try
            {
                string comm = "select id_pejabat as 'NIP', nama_pejabat as 'Nama Pejabat', jabatan as Jabatan, no_telp as 'No Telepon' from t_pejabat order by id_pejabat asc";
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

        

        public void tampilPejabatNIP(System.Windows.Forms.DataGridView ab, string nip)
        {
            try
            {
                string comm = "select id_pejabat as 'NIP', nama_pejabat as 'Nama Pejabat', jabatan as Jabatan, no_telp as 'No Telepon' from t_pejabat where id_pejabat LIKE '%" + nip + "%' order by id_pejabat asc";
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

        public void tampilPejabatNama(System.Windows.Forms.DataGridView ab, string materi)
        {
            try
            {
                string comm = "select id_pejabat as 'NIP', nama_pejabat as 'Nama Pejabat', jabatan as Jabatan, no_telp as 'No Telepon' from t_pejabat where nama_pejabat LIKE '%" + materi + "%' order by id_pejabat asc";
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
