using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace Aplikasi_undangan
{
    class c_login
    {
        public Boolean cekLogin(string id)
        {
            Boolean benar=false;
            try
            {
                string comm = "select * from t_pejabat where id_pejabat='"+id+"'";
                OdbcConnection conn = new OdbcConnection(Program.konek);
                OdbcCommand comd = new OdbcCommand(comm, conn);
                conn.Open();
                DataSet ds = new DataSet();
                OdbcDataAdapter da = new OdbcDataAdapter(comd);
                da.Fill(ds, "isi");
                conn.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    benar = true;
                }
            }
            catch (OdbcException ex)
            {
                benar = false;
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }

            return benar;
        }
    }
}
